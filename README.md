# 🦔 Sonic Rings & Chaos Emeralds (C#)

Um pequeno programa em C# que simula o Sonic coletando anéis (rings) e esmeraldas do caos para se transformar em suas formas especiais.

---

## 📄 Sobre

Este projeto demonstra conceitos básicos de:
- Programação Orientada a Objetos (POO)
- Classes, atributos, construtor e métodos
- Uso de listas (`List<string>`)
- Uso de números aleatórios com `Random`
- Interpolação de strings

---

## 🚀 Como funciona

O programa cria um objeto `Sonic` com atributos iniciais (`rings` e `esmeraldas`) zerados.  
Depois gera valores aleatórios para rings e esmeraldas e chama o método `PegarRingsEsmeraldas()`, que imprime no console os acontecimentos dependendo das regras do jogo.

---

## 📋 Requisitos

- .NET SDK instalado ([Download](https://dotnet.microsoft.com/download))
- Um editor de código como Visual Studio ou VS Code

---

## 🛠️ Como executar

1️- Clone ou baixe este repositório  
```bash
git clone https://github.com/Pedro-Kks/POO-Csharp-Sonic.git
````
2- Navegue até o projeto e rode os comandos
```bash
cd pasta-do-projeto
dotnet restore
dotnet build
dotnet run
```

🧪 Exemplo de saída
```bash
O Sonic tem atualmente 0 rings💍 e 0 esmeraldas.💎
O Sonic precisa pegar 7 Esmeraldas do Caos e coletar mais de 100 Anéis(Rings) para se transformar em Super Sonic, Lobo Ourinço, Hyper Sonic.
======================================================================================
O Sonic pegou 158 rings.
O Sonic pegou 5 esmeraldas.
======================================================================================
🤖 Dr.Robotnik roubou 2 esmeraldas.💎
O Sonic precisa derrotar Robotnik (Eggman) para recuperar as esmeraldas restantes!💎
>>> Quantidade de Rings💍 e Esmeraldas coletados💎:
Agora ele tem 158 Rings💍 e 5 Esmeraldas💎.
Rode o programa mais uma vez se quiser testar novamente.
```
📁 Estrutura do projeto

```bash
Consopro/
├── bin/                  ← ignorado pelo Git
├── obj/                  ← ignorado pelo Git
├── Program.cs            ← código principal
├── Consopro.csproj       ← arquivo de projeto
├── .gitignore            ← para ignorar bin/ e obj/
```

