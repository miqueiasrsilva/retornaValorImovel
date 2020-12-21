# retornaValorImovel v1.0

Projeto de uma Web API desenvolvida em .Net Core, utilizando a linguagem C#, na arquitetura MVC, que recebe a quantidade de metros quadrados e retorna o valor do imóvel em reais (R$).

Docker Hub:
https://hub.docker.com/repository/docker/miqueiasrsilva/retornavalorimovel

Publicação (método principal):
https://retorna-valor-imovel.herokuapp.com/v1/imovel/GetValorImovel

Documentação Swagger:
https://retorna-valor-imovel.herokuapp.com/swagger/index.html

Exemplo de utilização no PostMan:
1. Header: https://prnt.sc/w78wc9
2. Body: https://prnt.sc/w78vlt

Regras de validação:
O parâmetro de entrada "qtdeM2" (quantidade de metros quadrados) é obrigatório e deve estar entre 10 e 10.000.

# Informações adicionais sobre o projeto.

O projeto foi desenvolvido utilizando:

- ASP.NET Core: Framework Open Source da Microsoft para o desenvolvimento de aplicações.
- Git e GitHub: utilizados para versionamento e hospedagem do código-fonte.
- Swagger: Documentação técnica da API.
- Heroku: Plataforma em nuvem onde o serviço foi hospedado.
- Docker: Utilizado para entrega do software em pacote por meio de contêineres.
- Travis CI: Serviço de integração contínua utilizado para testar o software.
- MSTest: Framework da Microsfot utilizado para realização dos testes de unidade.
- Newtonsoft: utilizado para desserializar os objetos JSON.

Utilizada arquitetura MVC (Model-View-Controller), onde:

- Models: Camada que contem todas as entidades do projeto.
- Controllers: Camada que contem os Controllers do projeto, responsáveis por lidar com entradas de solicitações HTTP e enviar a resposta de volta ao requisitante.
- Views: não se aplica a este projeto.
