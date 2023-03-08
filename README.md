# ConquestOne

#API

A API foi constriída com as seguintes chamadas:
GET : Finance/Variacao/GetDatas/
Busca todos os dados e retorna em formato json

POST: /Finance/Variacao/Insert/
Insere os dados buscados no banco de dados

GET LAST30DAYS : /Finance/Variacao/Last30Days/
Busca no banco de dados o resultado das variações dos últimos 30 dias

Para acessar a API utilizar o link que é gerado contendo a porta e realizar a junção do nome do endereço da API https://localhost:7109/ + Finance/Variacao/GetDatas/ conforme deste exemplo:
https://localhost:7109/Finance/Variacao/GetDatas/

#BASE DE DADOS
Utilizado a seguinte query para criação da base de dados

USE [master] GO

Criando base da dados
* CREATE DATABASE [FinanceVariationDB] GO
USE [FinanceVariationDB] GO

Criando tabela para armazenar os dados 
* CREATE TABLE [TB_VARIACAO_DAILY] 

* ( [ID] INT PRIMARY KEY IDENTITY(1,1), 
[CL_DATE] DATETIME NOT NULL, 
[CL_VALUE] FLOAT NOT NULL, 
[CL_VARIATION_PREVIOUS_DATE] FLOAT NOT NULL, 
[CL_VARIATION_FIRST_DATE] FLOAT NOT NULL, ) 
GO

#LINK DE ACESSO AOS DADOS
https://query2.finance.yahoo.com/v8/finance/chart/PETR4.SA?symbol=PETR4.SA&period1=1675814400&period2=9999999999&interval=1d

Inicio 08/02/2023
Final: 08/03/2023
1 dia de Intervalo
