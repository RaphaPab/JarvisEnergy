using Microsoft.AspNetCore.Mvc;
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.IO;

namespace JarvisEnergy.Controllers
{
    
    public class DadosDispositivo
    {
        [LoadColumn(0)]
        public string NomeDispositivo { get; set; }

        [LoadColumn(1)]
        public string DescricaoDispositivo { get; set; }

        [LoadColumn(2)]
        public float Voltagem { get; set; }

        [LoadColumn(3)]
        public string Status { get; set; }

        [LoadColumn(4)]
        public float Temperatura { get; set; }

        [LoadColumn(5)]
        public float ConsumoWatts { get; set; }

        [LoadColumn(6)]
        public float CustoConsumo { get; set; } // Label para treinamento
    }

  
    public class PrevisaoConsumoPrevisto
    {
        [ColumnName("Score")]
        public float CustoConsumoPrevisto { get; set; } // Previsão do custo de consumo
    }

    
    [Route("api/[controller]")]
    [ApiController]
    public class PrevisaoController : ControllerBase
    {
        private readonly string caminhoModelo = Path.Combine(Environment.CurrentDirectory, "wwwroot", "MLModels", "ModeloConsumo.zip");
        private readonly string caminhoTreinamento = Path.Combine(Environment.CurrentDirectory, "Data", "dados_treinamento.csv");
        private readonly MLContext mlContext;

        public PrevisaoController()
        {
            mlContext = new MLContext();

            if (!System.IO.File.Exists(caminhoModelo))
            {
                Console.WriteLine("Modelo não encontrado. Iniciando treinamento...");
                TreinarModelo();
            }
        }

        private void TreinarModelo()
        {
            var pastaModelo = Path.GetDirectoryName(caminhoModelo);
            if (!Directory.Exists(pastaModelo))
            {
                Directory.CreateDirectory(pastaModelo);
                Console.WriteLine($"Diretório criado: {pastaModelo}");
            }

            
            IDataView dadosTreinamento = mlContext.Data.LoadFromTextFile<DadosDispositivo>(
                path: caminhoTreinamento, hasHeader: true, separatorChar: ',');

            // Pipeline de treinamento
            var pipeline = mlContext.Transforms.Categorical.OneHotEncoding("NomeDispositivo_encoded", nameof(DadosDispositivo.NomeDispositivo))
                .Append(mlContext.Transforms.Categorical.OneHotEncoding("DescricaoDispositivo_encoded", nameof(DadosDispositivo.DescricaoDispositivo)))
                .Append(mlContext.Transforms.Categorical.OneHotEncoding("Status_encoded", nameof(DadosDispositivo.Status)))
                .Append(mlContext.Transforms.Concatenate("Features",
                    "NomeDispositivo_encoded",
                    "DescricaoDispositivo_encoded",
                    "Status_encoded",
                    nameof(DadosDispositivo.Voltagem),
                    nameof(DadosDispositivo.Temperatura),
                    nameof(DadosDispositivo.ConsumoWatts)))
                .Append(mlContext.Regression.Trainers.Sdca(labelColumnName: nameof(DadosDispositivo.CustoConsumo), featureColumnName: "Features"));

            
            var modelo = pipeline.Fit(dadosTreinamento);

            
            mlContext.Model.Save(modelo, dadosTreinamento.Schema, caminhoModelo);
            Console.WriteLine("Modelo treinado e salvo com sucesso.");
        }

        [HttpPost("preverConsumo")]
        public ActionResult<PrevisaoConsumoPrevisto> PreverConsumo([FromBody] DadosDispositivo dados)
        {
            if (!System.IO.File.Exists(caminhoModelo))
            {
                return BadRequest("O modelo ainda não foi treinado.");
            }

            
            ITransformer modelo;
            using (var stream = new FileStream(caminhoModelo, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                modelo = mlContext.Model.Load(stream, out var _);
            }

            
            var enginePrevisao = mlContext.Model.CreatePredictionEngine<DadosDispositivo, PrevisaoConsumoPrevisto>(modelo);

            
            var previsao = enginePrevisao.Predict(dados);

            
            return Ok(previsao);
        }
    }
}
