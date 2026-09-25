# 💳 Sistema de Registro de Pagamentos (POO - Herança e Polimorfismo)

Este projeto é uma aplicação de console desenvolvida em C# para a disciplina de **PLATAFORMA DE DESENVOLVIMENTO DE SISTEMAS**[cite: 1]. O objetivo principal é aplicar os conceitos fundamentais de **herança** e **polimorfismo** no gerenciamento de transações financeiras[cite: 1].

---

## 🎯 Objetivos

- 🛠️ Implementar o conceito de **herança** para representar diferentes modalidades de pagamento[cite: 1].
- 🎭 Utilizar **polimorfismo** para a exibição customizada do resumo de cada pagamento em tela[cite: 1].
- 🖥️ Criar uma interface interativa de console com menu de opções[cite: 1].

---

## ⚡ Funcionalidades

O sistema permite interagir com um menu para registrar novos pagamentos ou listar as transações efetuadas[cite: 1]:

1. **💵 Pagamento À Vista (Dinheiro):**
   - Processa o valor total sem alterações[cite: 1].

2. **💳 Pagamento no Cartão de Débito:**
   - Solicita os últimos 4 dígitos do cartão[cite: 1].
   - Mantém o valor original do pagamento[cite: 1].

3. **💳 Pagamento no Cartão de Crédito:**
   - Solicita os últimos 4 dígitos do cartão[cite: 1].
   - Aplica um **desconto de 10%** sobre o valor total recebido[cite: 1].

4. **📋 Listagem e Resumo:**
   - Exibe o histórico de transações apresentando a forma de pagamento, valor original, desconto aplicado, últimos dígitos do cartão e valor final[cite: 1].

---

## 🛠️ Tecnologias Utilizadas

- 🟢 **Linguagem:** C#[cite: 1]
- ⚙️ **Plataforma:** .NET
- 💻 **Ambiente:** Aplicação de Console[cite: 1]

---

## 🏗️ Estrutura do Código

- `Program.cs`: Ponto de entrada da aplicação contendo o menu principal, leitura de dados e controle da lista de pagamentos[cite: 1].
- `Pagamento.cs`: Classe base (mãe) contendo os atributos e métodos genéricos compartilhados[cite: 1].
- `PagamentoDinheiro.cs`: Classe filha especializada em pagamentos em dinheiro[cite: 1].
- `PagamentoDebito.cs`: Classe filha com suporte aos dados do cartão de débito[cite: 1].
- `PagamentoCredito.cs`: Classe filha com cálculo de desconto e suporte aos dados do cartão de crédito[cite: 1].

---

## 🚀 Como Executar

1. **Clonar o repositório:**
   ```bash
   git clone [https://github.com/22felipefdev/poo-atividade-heranca.git](https://github.com/22felipefdev/poo-atividade-heranca.git)
