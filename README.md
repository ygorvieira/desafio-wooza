# Desafio Wooza
Teste para a vaga de Desenvolvedor Backend

## Tecnologias utilizadas
.NET Core

Banco de Dados SQL Server

MicroORM Dapper

Visual Studio 2017

## Lista de endpoints

**Operadoras**

**GET:** http://localhost:{nº da porta}/api/operadora/GetOperadoras

**GET por CODIGO DO PLANO:** http://localhost:{nº da porta}/api/operadora/GetOperadora/ID/{id}/

**POST:**  http://localhost:{nº da porta}/api/operadora/PostOperadora/

**PUT:**  http://localhost:{nº da porta}/api/operadora/UpdateOperadora/ID/{id}/

**DELETE:** http://localhost:{nº da porta}/api/operadora/RemoveOperadora/ID/{id}/

**Planos**

**GET:** http://localhost:{nº da porta}/api/plano/GetPlanos

**GET por ID:** http://localhost:{nº da porta}/api/plano/GetPlano/ID/{id}/DDD/{ddd}/

**GET por TIPO:** http://localhost:{nº da porta}/api/plano/GetPlanoPorTipo/TIPO/{tipo}/DDD/{ddd}/

**GET por OPERADORA:** http://localhost:{nº da porta}/api/plano/GetPlanoPorOperadora/OPERADORA/{operadora}/DDD/{ddd}

**POST:**  http://localhost:{nº da porta}/api/plano/PostPlano/

**PUT:**  http://localhost:{nº da porta}/api/plano/UpdatePlano/ID/{id}/

**DELETE:** http://localhost:{nº da porta}/api/plano/RemovePlano/ID/{id}/