# O que é o Sol-cli?
É uma simples interface de linha de comando para criar arquivos de código em C++<b>
com um template voltado para competições de programação.

## Tecnologias Utilizadas :pushpin:
- [C#](https://learn.microsoft.com/en-us/dotnet/csharp/): Linguagem de programação<br>
- [.NET](https://dotnet.microsoft.com/en-us/download/dotnet)<br>

## Como instalar o Sol-cli :white_check_mark:
1. Instale o **.NET 8.0** através desse [link](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
2. Faça o clone desse [repositório](https://github.com/AlexandreDantasz/Gollog) na sua máquina:
    - Crie uma pasta no seu computador para esse programa.
    - Abra o `git bash` ou `terminal` dentro dessa pasta.
    - Digite `git clone https://github.com/AlexandreDantasz/GerenciadorDeCargas` e pressione `enter`
    - Ainda no terminal, entre na pasta do projeto executando o comando `cd sol-cli`
    - execute os seguintes comandos: `dotnet pack` e `dotnet tool install --global --add-source ./nupkg sol.cli`

## Como usar :question:
Em qualquer terminal, basta digitar `sol <nome do arquivo>` e pressionar `enter`.
- Certifique-se de que não há nenhum arquivo existente no mesmo diretório com o mesmo nome e com a extensão ".cpp".