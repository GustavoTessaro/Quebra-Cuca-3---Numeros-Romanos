# 🔢 Conversor de Números Romanos

![C#](https://img.shields.io/badge/C%23-.NET-purple)
![Console Application](https://img.shields.io/badge/Type-Console%20Application-blue)
![Status](https://img.shields.io/badge/Status-Concluído-success)

## 📖 Sobre o Projeto

Este projeto é uma aplicação de console desenvolvida em **C#** que permite realizar conversões entre números decimais e números romanos.

O sistema oferece duas funcionalidades principais:

- Converter um número decimal para romano;
- Converter um número romano para decimal.

Além disso, possui validações para garantir que apenas valores válidos sejam processados.

---

## 🚀 Funcionalidades

### 🔹 Decimal → Romano

Converte números inteiros entre **1 e 3999** para sua representação em algarismos romanos.

**Exemplos:**

| Decimal | Romano |
|----------|----------|
| 1 | I |
| 4 | IV |
| 9 | IX |
| 58 | LVIII |
| 1994 | MCMXCIV |
| 3999 | MMMCMXCIX |

---

### 🔹 Romano → Decimal

Converte números romanos para seus respectivos valores decimais.

**Exemplos:**

| Romano | Decimal |
|---------|---------|
| I | 1 |
| IV | 4 |
| IX | 9 |
| XL | 40 |
| XC | 90 |
| MCMXCIV | 1994 |

---

## 🏗️ Estrutura do Código

### `Main()`

Método principal da aplicação.

Responsável por:

- Exibir o menu principal;
- Receber a escolha do usuário;
- Chamar a conversão desejada;
- Permitir novas conversões ou encerrar o programa.

---

### `ConverterDecimalParaRomano()`

Solicita ao usuário um número decimal válido entre **1 e 3999**.

Após a validação, chama o método:

```csharp
ConversorDeNumeros()
```

para gerar o número romano correspondente.

---

### `ConversorDeNumeros(int numeroDecimal)`

Responsável pela conversão de decimal para romano.

Utiliza quatro vetores:

```csharp
unidades[]
dezenas[]
centenas[]
milhares[]
```

Cada posição do vetor representa uma combinação válida de algarismos romanos.

Exemplo:

```csharp
1987
```

é convertido em:

```text
M + CM + LXXX + VII
=
MCMLXXXVII
```

---

### `ConverterRomanoParaDecimal()`

Solicita ao usuário um número romano.

Antes da conversão, chama:

```csharp
ValidarNumeroRomano()
```

para verificar se todos os caracteres são válidos.

Após a validação, chama:

```csharp
ConversorDeNumerosRomanos()
```

---

### `ValidarNumeroRomano(string numeroRomano)`

Verifica se os caracteres digitados pertencem ao conjunto:

```text
I
V
X
L
C
D
M
```

Caso encontre qualquer caractere inválido, retorna:

```csharp
false
```

---

### `ConversorDeNumerosRomanos(string numeroRomano)`

Realiza a conversão de romano para decimal.

O algoritmo percorre a string da direita para a esquerda.

Regra utilizada:

- Se o valor atual for menor que o anterior → subtrai.
- Caso contrário → soma.

Exemplo:

```text
IX
```

Passo a passo:

```text
X = 10
I = 1

1 < 10
Logo:

10 - 1 = 9
```

Resultado:

```text
IX = 9
```

---

### `ObterValorDecimal(char simbolo)`

Retorna o valor decimal correspondente ao símbolo romano.

| Símbolo | Valor |
|----------|----------|
| I | 1 |
| V | 5 |
| X | 10 |
| L | 50 |
| C | 100 |
| D | 500 |
| M | 1000 |

---

## 🧠 Lógica Utilizada

### Conversão Romano → Decimal

O algoritmo utiliza a regra clássica dos números romanos:

Quando um símbolo menor aparece antes de um maior, seu valor é subtraído.

Exemplos:

```text
IV = 4
IX = 9
XL = 40
XC = 90
CD = 400
CM = 900
```

---

### Conversão Decimal → Romano

A conversão utiliza tabelas pré-definidas contendo todas as combinações possíveis para:

- Unidades
- Dezenas
- Centenas
- Milhares

Isso torna a conversão rápida e eficiente.

---

## ▶️ Como Executar

### Pré-requisitos

- .NET SDK instalado

Verificar instalação:

```bash
dotnet --version
```

---

### Executando o Projeto

Clone o repositório:

```bash
git clone https://github.com/seu-usuario/conversor-romanos.git
```

Entre na pasta:

```bash
cd conversor-romanos
```

Execute:

```bash
dotnet run
```

---

## 💻 Exemplo de Uso

```text
Digite 1 para converter um número decimal para romano ou 2 para converter um número romano para decimal:

1

Digite um número decimal inteiro entre 1 e 3999:

2025

O número romano correspondente é:

MMXXV
```

---

## 📚 Conceitos Aplicados

- Estruturas de repetição (`do while`)
- Estruturas de decisão (`switch`)
- Vetores (Arrays)
- Métodos
- Manipulação de Strings
- Conversão Numérica
- Validação de Dados
- Algoritmos de Conversão

---

Desenvolvido como exercício de lógica de programação utilizando **C# e .NET**.
