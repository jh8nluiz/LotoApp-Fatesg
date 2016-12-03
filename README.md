# LotoApp-Fatesg
Projeto do curso de pós graduação na disciplina de Universal Windows APP

## Contexto
O Projeto é um aplicativo de jogos de loterias desenvolvido como trabalho da matéria de Desenvolvimento para Universal Apps da pós graduação de Desenvolvimento Mobile FATESG 2016, apoiado por [Rodrigo Kono] - docente e palestrante com diversas certificações na plataforma Microsoft.

## O que é
Seu escopo se restringe a trazer os resultados de todos jogos de loteria da Caixa Econômica Federal, bem como listar os números mais sorteados e permitir a realização de apostas – de forma manual ou aleatória.

## Integrantes
  - Gustavo Gomes da Fé
  - Luiz Alfredo
  - Murilo

## Divisão do Trabalho
O trabalho foi dividido em três partes: design, consumo de serviços e persistência, sendo cada uma atribuída ao Luiz Alfredo, Gustavo Gomes e Murilo respectivamente.

## Arquitetura
A aplicação utiliza como ferramenta o Visual Studio 2016 para projetos em Universal Apps. A grande vantagem é replicar o aplicativo para todas as plataformas para uso final da Microsoft, incluindo a parte mobile. 
O aplicativo consiste em três partes: design de telas, consumo de serviços e persistência de dados. 

### Design de telas
Foi utilizado as ferramentas do Visual Studio: Arquivos XAML, com ícones personalizados dos diversos modos de jogos lotéricos presentes no aplicativo.

### Consumo de Serviços
Foi adotado para consumo de serviços o REST, sendo os endpoints pertencentes a [Confira Loterias]. Para se ter acesso, foi necessário pagar pelo uso do serviço. Assim, o terceiro disponibilizou uma chave/token de acesso para consumo da API.

### Persistência
No quesito persistência foi utilizado o [SQlite .NET] pelo fato de ser simplificado, open source e de fácil integração com a plataforma .NET, aumentando a produtividade devido à facilidade de uso.

## Telas do aplicativo
![alt text](https://s11.postimg.org/95m6npcqn/Screen_Shot_2016_12_03_at_12_16_59_AM.png "Página Principal - Resultados")
![alt text](https://s11.postimg.org/dg0ujahtr/Screen_Shot_2016_12_03_at_12_25_20_AM.png "Realização de Jogos")

### Ícone
![alt text](https://s12.postimg.org/d4j1m4tdp/Screen_Shot_2016_12_03_at_12_40_18_PM.png "Ícone Principal")

## Requisitos
- [X] Listar os resultados mais recentes dos diversos tipos de jogos lotéricos
- [X] Registrar jogos
- [ ] Salvar as dezenas favoritas
- [ ] Notificar usuário quando sair o resultado de cada jogo
- [X] Verificar quais números saem com mais frequência
[Rodrigo Kono]: <https://github.com/rodrigokono>
[Confira Loterias]: <http://portal.confiraloterias.com.br/>
[SQlite .NET]: <https://github.com/praeclarum/sqlite-net>

