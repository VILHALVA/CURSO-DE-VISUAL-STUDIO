# PRIMEIRA APLICAÇÃO E CONCEITOS BÁSICOS
Vamos criar uma aplicação simples para entender os conceitos básicos no Visual Studio 2022. Neste exemplo, criaremos um projeto de console usando C#.

**Passos para criar a primeira aplicação:**

1. **Inicie o Visual Studio 2022:**
   - Abra o Visual Studio 2022 após a instalação.

2. **Crie um Novo Projeto:**
   - Clique em "File" (Arquivo) -> "New" (Novo) -> "Project" (Projeto).
   - Escolha "Console App" (Aplicativo de Console) em C#.

3. **Configure o Projeto:**
   - Dê um nome ao seu projeto e escolha um local para salvar.
   - Clique em "Create" (Criar).

4. **Escreva o Código:**
   - O Visual Studio irá criar um arquivo chamado `Program.cs`. Abra esse arquivo e você verá algo assim:

    ```csharp
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");
        }
    }
    ```

5. **Execute a Aplicação:**
   - Pressione `F5` ou clique em "Start" (Iniciar) para compilar e executar o programa.

6. **Veja a Saída:**
   - Você deverá ver a mensagem "Hello, World!" no console.

Aqui estão alguns conceitos básicos neste exemplo:

- **`using System;`:** Uma declaração `using` para incluir o namespace `System`, que contém classes fundamentais para entrada/saída, manipulação de exceções, etc.

- **`class Program`:** Uma classe chamada `Program`, que contém o método `Main`.

- **`static void Main()`:** O método principal, onde a execução do programa começa. O código dentro deste método é executado quando o programa é iniciado.

- **`Console.WriteLine("Hello, World!");`:** Uma instrução que escreve "Hello, World!" no console. O `Console.WriteLine` exibe texto no console e adiciona uma quebra de linha.

Esse é um exemplo básico para começar. À medida que você avança, aprenderá sobre variáveis, estruturas de controle de fluxo, funções, orientação a objetos, e muitos outros conceitos que são fundamentais para o desenvolvimento de software. 