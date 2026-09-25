# 💳 Sistema de Registro de Pagamentos (POO - Herança e Polimorfismo)

Este projeto é uma aplicação de console desenvolvida em C# para a disciplina de **PLATAFORMA DE DESENVOLVIMENTO DE SISTEMAS**. O objetivo principal é aplicar os conceitos fundamentais de **herança** e **polimorfismo** no gerenciamento de transações financeiras.

---

## 🎯 Objetivos

- 🛠️ Implementar o conceito de **herança** para representar diferentes modalidades de pagamento.
- 🎭 Utilizar **polimorfismo** para a exibição customizada do resumo de cada pagamento em tela.
- 🖥️ Criar uma interface interativa de console com menu de opções.

---

## ⚡ Funcionalidades

O sistema permite interagir com um menu para registrar novos pagamentos ou listar as transações efetuadas:

1. **💵 Pagamento À Vista (Dinheiro):**
   - Processa o valor total sem alterações.

2. **💳 Pagamento no Cartão de Débito:**
   - Solicita os últimos 4 dígitos do cartão.
   - Mantém o valor original do pagamento.

3. **💳 Pagamento no Cartão de Crédito:**
   - Solicita os últimos 4 dígitos do cartão.
   - Aplica um **desconto de 10%** sobre o valor total recebido.

4. **📋 Listagem e Resumo:**
   - Exibe o histórico de transações apresentando a forma de pagamento, valor original, desconto aplicado, últimos dígitos do cartão e valor final.

---

## 🛠️ Tecnologias Utilizadas

- 🟢 **Linguagem:** C#
- ⚙️ **Plataforma:** .NET
- 💻 **Ambiente:** Aplicação de Console

---

## 🏗️ Estrutura do Código

- `Program.cs`: Ponto de entrada da aplicação contendo o menu principal, leitura de dados e controle da lista de pagamentos.
- `Pagamento.cs`: Classe base (mãe) contendo os atributos e métodos genéricos compartilhados.
- `PagamentoDinheiro.cs`: Classe filha especializada em pagamentos em dinheiro.
- `PagamentoDebito.cs`: Classe filha com suporte aos dados do cartão de débito.
- `PagamentoCredito.cs`: Classe filha com cálculo de desconto e suporte aos dados do cartão de crédito.

---

## 🚀 Como Executar

1. **Clonar o repositório:**
   ```bash
   git clone [https://github.com/22felipefdev/poo-atividade-heranca.git](https://github.com/22felipefdev/poo-atividade-heranca.git)
