# CRIE UMA BIBLIOTECA (DLL) E ADICIONE-A AO PROJETO COM C# E .NET
Vamos criar uma biblioteca de classe (DLL) em C# e .NET e, em seguida, adicionar essa biblioteca a um projeto. Aqui está um exemplo passo a passo:

**Criar a Biblioteca de Classe (DLL):**

1. **Abra o Visual Studio 2022:**
   - Inicie o Visual Studio e clique em "Create a new project" (Criar um novo projeto).

2. **Escolha o Tipo de Projeto:**
   - Selecione "Class Library" (Biblioteca de Classe) em C#.

3. **Configure o Projeto:**
   - Escolha um nome e local para o projeto. Clique em "Create" (Criar).

4. **Escreva Código na Biblioteca:**
   - Abra o arquivo gerado automaticamente chamado `Class1.cs` e substitua o código por algo assim:

    ```csharp
    using System;

    namespace MinhaBiblioteca
    {
        public class Calculadora
        {
            public int Somar(int a, int b)
            {
                return a + b;
            }

            public int Subtrair(int a, int b)
            {
                return a - b;
            }
        }
    }
    ```

5. **Compilar a Biblioteca:**
   - Compile o projeto para gerar a DLL. Isso pode ser feito pressionando `Ctrl + Shift + B` ou clicando com o botão direito do mouse no projeto e escolhendo "Build" (Compilar).

Agora, temos uma biblioteca de classe simples com uma classe chamada `Calculadora` que tem métodos de soma e subtração.

**Adicionar a DLL a um Projeto:**

Agora, vamos criar um novo projeto para usar essa DLL:

1. **Crie um Novo Projeto:**
   - Crie um novo projeto, por exemplo, um projeto de Console Application.

2. **Adicione uma Referência à DLL:**
   - Clique com o botão direito no projeto e escolha "Add" (Adicionar) -> "Reference" (Referência).
   - Vá para "Projects" (Projetos) e selecione o projeto da biblioteca de classe.

3. **Use a Biblioteca no Código:**
   - No arquivo do código-fonte do seu projeto, você pode agora usar a classe `Calculadora` da biblioteca:

    ```csharp
    using System;

    class Program
    {
        static void Main()
        {
            MinhaBiblioteca.Calculadora calculadora = new MinhaBiblioteca.Calculadora();

            int resultadoSoma = calculadora.Somar(5, 3);
            int resultadoSubtracao = calculadora.Subtrair(8, 2);

            Console.WriteLine($"Soma: {resultadoSoma}");
            Console.WriteLine($"Subtração: {resultadoSubtracao}");
        }
    }
    ```

4. **Execute o Projeto:**
   - Execute o projeto e veja como ele utiliza a biblioteca que você criou.

Este é um exemplo básico para ajudar a começar. À medida que você se torna mais familiarizado com o desenvolvimento em C# e .NET, você poderá criar bibliotecas mais complexas e integrá-las em seus projetos de maneiras mais sofisticadas.