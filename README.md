# JarvisEnergy - GlobalSolution


## Integrantes
- Raphael Pabst rm98525
- Silvio Junior rm550821
- Pedro Braga rm551061
- Eduardo Reis Braga rm551987
- Vinícius Martins Torres Abdala rm99455


# Tecnologias Utilizadas:

## Implementação da API
- ASP.NET Core Web API: Framework de desenvolvimento.
- Banco de dados Oracle: Para operações CRUD (Create, Read, Update, Delete).
- Swagger/OpenAPI: Documentação interativa dos endpoints.
- Padrão de Criação: Usaremos o JSON para o gerenciador de configurações.

## Arquitetura utilizada

A arquitetura monolítica é um estilo de desenvolvimento de software em que todos os componentes e funcionalidades de uma aplicação estão unificados em um único bloco ou sistema. Em uma aplicação monolítica, o front-end, o back-end, o gerenciamento de dados e a lógica de negócios são integrados em um único código-fonte e executados juntos. Essa abordagem facilita o desenvolvimento inicial, pois os componentes podem compartilhar recursos diretamente, o que simplifica a comunicação interna. No entanto, à medida que a aplicação cresce em complexidade e tamanho, a manutenção e escalabilidade tornam-se desafiadoras. Qualquer alteração, por menor que seja, exige a recompilação e o redeployment da aplicação inteira, o que aumenta o tempo de atualização e a complexidade de testes. A arquitetura monolítica é eficaz para projetos de menor porte, mas muitas vezes limita a agilidade e escalabilidade em sistemas grandes, o que leva muitas organizações a optar por arquiteturas baseadas em microsserviços para suportar sistemas mais complexos e distribuídos.

## Arquitetura da API


Este repositório contém uma API RESTful construída em ASP.NET Core, que gerencia dados de dispositivos conectados na rede sobre consumo energético e oferece uma funcionalidade de previsão baseada em Machine Learning de previsão do custo de consumo do dispositivo. A aplicação utiliza o Entity Framework Core para persistência de dados.

- Models/: Define as classes de modelo do domínio, como Dispositivo e Usuário.
- Controllers/: Contém os controladores responsáveis por gerenciar as requisições HTTP.
- Data/: Contém o contexto do banco de dados (AppDbContext).
- Data/dados_treinamento.csv: Contém os dados para treinar o modelo de previsão.
- wwwroot/MLModels/: Armazena o modelo treinado de Machine Learning.


---

## Padrão de Criação

Optamos pelo uso do padrão JSON (JavaScript Object Notation) no desenvolvimento de APIs devido aos inúmeros benefícios que ele proporciona, tanto em termos técnicos quanto de usabilidade. Um dos principais motivos é sua ampla compatibilidade. JSON é suportado por praticamente todas as linguagens de programação modernas, o que facilita a integração das APIs com diferentes sistemas e plataformas. Isso significa que independentemente do ambiente em que estejam trabalhando, podemos consumir e produzir dados de forma consistente em outras APIs.

## Funcionalidades

 1. CRUDs de Dispositivos,Usuários, Endereço, Telefone e Relatório: Permite criar, ler, atualizar e deletar.

 3. Previsão de Produto com IA Generativa: Implementa uma API para prever o custo dos dispositivos com base nas características inseridas, utilizando Machine Learning.
 4. Treinamento de Modelo ML: Treina um modelo de IA para prever o nome do produto com base em dados históricos.
 5. Dados: Csv de treinamento contendo + de 7 mil linhas de dados (80%) e csv de Testes (20%) para melhor adequação de aprendizagem de máquina.

---


## Funcionalidade de IA Generativa

# Detalhes do Modelo de IA

O projeto utiliza o Microsoft ML.NET para treinar um modelo de classificação multi-classe, que prevê o custo do dispositivo  com base em características, como Dispositivo, Voltagem, Temperatura e  Consumo de Watts.
A ideia é usar IA generativa para analisar esses dados e gerar uma previsão para o possível custo mensal do dispositivo. Isso é particularmente útil no Setor de Energia Renovável, onde o custo por dispositivo pode impactar diretamente na vida das pessoas,empresas e comunidades. Com base no comportamento do usuário, a IA pode prever qual é o custo específico de cada dispositivo, evitando desperdícios e aumentando a eficácia.


JSON para Testes em PrevisaoController

{
  "NomeDispositivo": "Televisão",
  "DescricaoDispositivo": "Eletrônico de entretenimento",
  "Voltagem": 125.15,
  "Status": "Ligado",
  "Temperatura": 29.76,
  "ConsumoWatts": 95.97
}


---

## Práticas de Clean Code

O projeto segue princípios de Clean Code para garantir legibilidade, manutenção e qualidade de código. Algumas práticas adotadas incluem:

- Naming Conventions: Todos os métodos, variáveis e classes seguem convenções de nomenclatura claras, que indicam sua funcionalidade.
- Tratamento de Erros: O código captura exceções específicas e retorna respostas apropriadas ao Usuário, como NotFound e BadRequest.
- Injeção de Dependência: A API utiliza injeção de dependência para o contexto do banco de dados (AppDbContext) facilitando o teste e a manutenção do código.
- Responsabilidade Única: Cada classe e método possui uma única responsabilidade. Por exemplo, o DispositivoController gerencia operações CRUD e PrevisaoController cuida das previsões de produtos.
- Os endpoints responsáveis pelas operações CRUD (Create, Read, Update e Delete) serão implementados seguindo essa arquitetura monolítica. Isso implica que todas as operações relativas aos recursos da API, como a criação de novos registros, leitura, atualização e remoção de dados, estarão centralizadas no mesmo núcleo da aplicação, permitindo uma gestão unificada e simplificada dos dados e funcionalidades.


---
## Como executar a API

**Pré-requisitos**
- .NET 6.0 ou superior
- Banco de Dados Oracle
  
**Passos para Execução**
  1. Clone o repositório:

    
    git clone https://github.com/RaphaPab/JarvisEnergy
     
  3. Configure as variáveis de ambiente com as credenciais de acesso ao banco Oracle.

  4. Execute as migrações do banco de dados:

    dotnet ef database update

  4.Inicie a aplicação:
  
      Clique em https.
      
  ![image](https://github.com/user-attachments/assets/266cf312-9dbc-41ac-9c08-203886ca308b)
  



---

## Endpoints CRUD

- **PrevisaoController**
  Controller responsável por prever o consumo com base nas características informadas.

  - **POST**
 
    ![image](https://github.com/user-attachments/assets/18d16dda-1cac-4e3c-ae3e-75d73c29b26a)




    

  
Os endpoints da API seguem o padrão **CRUD** (Create, Read, Update, Delete) para os recursos:

- **Dispositivos**
- **Usuários**
- **Endereços**
- **Telefones**
- **Relatórios**

Cada recurso interage com o banco de dados **Oracle** utilizando o **Entity Framework Core**, garantindo a integração e manipulação de dados de forma eficiente. Os seguintes métodos RESTful são implementados:

- **GET**: Recupera recursos.
- **POST**: Cria novos recursos.
- **PUT**: Atualiza recursos existentes.
- **DELETE**: Exclui recursos.

Esses métodos estão disponíveis para todos os recursos mencionados, garantindo conformidade com as práticas recomendadas de APIs RESTful.

- **GET**


- endpoint
- exemplo corpo de resposta


- **POST**

- endpoint
- exemplo corpo de request
- exemplo corpo


- **PUT**
- endpoint
- exemplo corpo de request
- exemplo corpo de resposta


DELETE

- endpoint
- exemplo de request
- não há corpo de resposta


**HTTP responses**
| Código | Descrição |
|---|---|
| 200 | Requisição executada com sucesso (success)|
| 400 | Bad request|
| 404 | Registro pesquisado não encontrado (Not found)|
| 500 | Internal server error|

---

- [Listagem de Usuários](#Buscar_Lista_de_Usuarios)
- [Enviar dados](#Enviar_dados)
- [Listar Usuarios por ID](#Listar_Usuarios_por_ID)
- [Alterar dados no sistema](#Alterar_dados_no_sistema)
- [Deletar dados no sistema](#Deletar_dados_no_sistema)

Alterar dados no sistema
---

### Buscar_Lista_de_Usuarios

#### Endpoint

- **Método**: GET  
- **URL**: 'localhost:7260/api/Usuarios'

- #### Descrição
Este endpoint retorna uma Lista de clientes cadastrados no sistema.

Exemplo Corpo de resposta

![image](https://github.com/user-attachments/assets/61ce6034-2804-4ff1-a525-ce9046ef77aa)



Exemplo Corpo do request

![image](https://github.com/user-attachments/assets/25549e37-2dba-4c0b-93be-13fc06e42c07)




### Enviar_dados

#### Endpoint

- **Método**: POST  
- **URL**: 'localhost:7260/api/Usuarios'

#### Descrição
Este endpoint envia dados do cliente para o banco de dados.

Exemplo Corpo de resposta
![image](https://github.com/user-attachments/assets/00190cdf-6a09-4bc8-95f8-6948d5196bf6)



Exemplo Corpo do request
 {
    "idUsuario": 3,
    "nomeUsuario": "Ana Souza",
    "cpf": "321.654.987-22",
    "rg": "32.165.498-7",
    "dataNascimento": "2000-10-10T00:00:00",
    "senha": "senhaSegura789"
  }



### Listar_Cliente_por_ID



#### Endpoint

- **Método**: GET  
- **URL**: 'localhost:7260/api/Usuarios'

- #### Descrição
Este endpoint retorna o ID do cliente cadastrado no sistema.

Exemplo Corpo de resposta
![image](https://github.com/user-attachments/assets/d631c32e-575b-4e67-b6ea-5fcdc6d139ae)

Exemplo Corpo do request
![image](https://github.com/user-attachments/assets/87c1d3bd-45a2-452a-bc00-3a533183b817)


### Alterar_dados_no_sistema



#### Endpoint

- **Método**: PUT  
- **URL**: 'localhost:7260/api/Usuarios/3'

- #### Descrição
Este endpoint altera os dados do usuário cadastrado no sistema.

Exemplo Corpo de resposta
![image](https://github.com/user-attachments/assets/777b54e5-6562-4c8d-ac96-a1ff1f0e9f37)



Exemplo Corpo do request
![image](https://github.com/user-attachments/assets/7cb9c389-776c-4c81-909a-4b1b4fa5337e)




### Deletar_dados_no_sistema



#### Endpoint

- **Método**: DELETE  
- **URL**: 'localhost:7260/api/Usuarios/3'

- #### Descrição
Este endpoint deleta os dados do cliente cadastrado no sistema de acordo com o ID.

Exemplo Corpo de resposta
![image](https://github.com/user-attachments/assets/12aa3cc3-832d-4794-8872-78e010a3c94a)


Dispositivos


GET
/api/Dispositivos
corpo 
![image](https://github.com/user-attachments/assets/bbee67a1-a122-4273-818e-75276f3d083c)

![image](https://github.com/user-attachments/assets/3a5a2e35-b02e-4b10-bf14-905a9f8a3da4)


### Endpoints CRUD - Dispositivos
Os dispositivos podem ser gerenciados através dos seguintes endpoints:

**GET - Buscar Dispositivos**
URL: /api/Dispositivos
Descrição: Retorna uma lista de todos os dispositivos cadastrados.
Exemplo de Corpo de Resposta:

![image](https://github.com/user-attachments/assets/bbee67a1-a122-4273-818e-75276f3d083c)

![image](https://github.com/user-attachments/assets/3a5a2e35-b02e-4b10-bf14-905a9f8a3da4)


###  - Adicionar Dispositivo
URL: /api/Dispositivos
Descrição: Cria um novo dispositivo no sistema.

*Exemplo de corpo de solicitação:
Json:{
    "idDispositivo": 1,
    "nomeDispositivo": "Televisão",
    "descricaoDispositivo": "Eletrônico de entretenimento",
    "voltagem": "127V",
    "status": "Ligado",
    "temperatura": "29.76°C",
    "consumoWatts": 125.15,
    "custoConsumo": 95.97
}

![image](https://github.com/user-attachments/assets/6d2dd0d8-da84-4242-a656-fac9af845ae7)

Exemplo de corpo de resposta:
![image](https://github.com/user-attachments/assets/0926298f-3a61-4b16-8095-10d70d6f5ecc)



## PUT - Atualizar Dispositivo
Descrição: Atualiza os dados de um dispositivo existente.
URL: /api/Dispositivos/3

![image](https://github.com/user-attachments/assets/d7d7c7d3-0c05-4e96-b660-6718d6170f5f)





#DELETE - Excluir Dispositivo
URL: /api/Dispositivos/3
Descrição: Exclui um dispositivo baseado no ID.


![image](https://github.com/user-attachments/assets/b3f93b3e-4e6a-40ff-a030-a29436ec719b)











