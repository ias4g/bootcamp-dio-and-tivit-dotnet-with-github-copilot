# 🚀 DESAFIO DE PROJETO

### 🎓 DIO - Trilha .NET - Fundamentos

#### 📝 Sobre o Desafio

Para este desafio, você precisará aplicar os conhecimentos adquiridos no módulo de fundamentos da trilha .NET da DIO. É hora de colocar a mão na massa com C#!

#### 🏢 Contexto

Você foi contratado para construir um sistema para um **estacionamento**. O objetivo é gerenciar os veículos, realizando operações essenciais como adicionar e remover automóveis, além de calcular o valor devido e listar a frota atual.

#### 🏗️ Proposta: Classe `Estacionamento`

Você deverá implementar a classe base seguindo a estrutura lógica abaixo:

![Diagrama de classe estacionamento](../images/diagrama_classe_estacionamento.png)


**Variables (Atributos):**

* **`precoInicial`** (decimal): O valor fixo cobrado apenas por entrar no estacionamento.
* **`precoPorHora`** (decimal): O valor cobrado por cada hora que o veículo permanecer na vaga.
* **`veiculos`** (List<string>): Uma lista que armazena as **placas** dos veículos estacionados.

---

#### 🛠️ Funcionalidades Esperadas (Métodos)

* **➕ AdicionarVeiculo**: Solicita a placa ao usuário e a armazena na lista `veiculos`.
* **➖ RemoverVeiculo**:
  1. Verifica se a placa existe no sistema.
  2. Pede a quantidade de horas que o veículo ficou parado.
  3. Calcula o valor total. A fórmula lógica é:
  4. Remove a placa da lista.


* **📋 ListarVeiculos**: Exibe todas as placas estacionadas. Se a lista estiver vazia, mostra a mensagem: *"Não há veículos estacionados"*.

---

#### 🎮 Menu Interativo

O programa deve exibir um menu em loop com as seguintes opções:

1. **🚗 Cadastrar veículo**
2. **🗑️ Remover veículo**
3. **📖 Listar veículos**
4. **❌ Encerrar**

#### 💡 Instruções de Solução

O código inicial está disponível com marcações **"TODO"** (A fazer). Sua missão é substituir esses comentários pela lógica de programação correta para que o sistema funcione perfeitamente.

---

> **Dica:** Fique atento à conversão de tipos (strings para inteiros/decimais) ao receber dados do console!

<br>
<br>
<br>
<br>

<hr>
<div align="center">
   👋 Feito com ❤️ by Izael Silva 👋
<br>
<br>
<br>
   créditos:
<a href="https://web.dio.me/home" target="_blank">

![Dio-Logo](/images/dio.png)

</a>
</div>