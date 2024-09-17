# PayMart.Payments

**Atenção:** Este projeto faz parte de uma arquitetura de microserviços e depende de outras APIs para funcionar corretamente. Certifique-se de que o `PayMart.BFF` está rodando, assim como as outras APIs mencionadas.

## Descrição do Projeto

O `PayMart.Payments` é responsável pelo gerenciamento de pagamentos no sistema PayMart. Ele permite operações como processamento de pagamentos, consulta de status de pagamento e reembolso. O microserviço foi desenvolvido em .NET Core 8 e segue boas práticas de desenvolvimento como SOLID e Design Patterns.

## Funcionalidades

- **Processamento de Pagamentos**: Processamento de pagamentos de pedidos utilizando diversas formas de pagamento.
- **Consulta de Status de Pagamento**: Permite consultar o status de um pagamento realizado.
- **Reembolso**: Realiza o reembolso de pagamentos.

## Estrutura do Projeto

O projeto segue uma estrutura modular organizada em camadas:

- **API Layer**
- **Application Layer**
- **Domain Layer**
- **Infrastructure Layer**

## Tecnologias Utilizadas

- **.NET Core 8**
- **SQL Server**
- **Entity Framework Core**
- **Docker**

## Pré-requisitos

Antes de iniciar o projeto, certifique-se de ter as seguintes ferramentas instaladas:

- [.NET Core 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- [Docker](https://www.docker.com/)
- [Git](https://git-scm.com/)

## Configuração do Projeto

### 1. Clonar o Repositório

```bash
git clone https://github.com/seuusuario/Pa
