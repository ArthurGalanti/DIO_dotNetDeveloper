using DIO_dotNetDeveloper.models; // NAMESPACE DAS CLASSES
// // ############################# MENU ITERATIVO
string opcao;
bool exibirMenu = true;
while (exibirMenu == true)
{
    Thread.Sleep(2000); // Para esperar um pouco antes de limpar o menu
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Busca de cliente");
            break;
        case "3":
            Console.WriteLine("Exclusão de cliente");
            break;
        case "4":
            Console.WriteLine("Encerrando!");
            exibirMenu = false;
            // Environment.Exit(0);
            break;
        default:
            break;
    }
    if (opcao == "4")
    {
        Console.WriteLine("O programa foi encerrado!");
    }

}

// // ############################# LAÇOS DE REPETIÇÃO
// //*****LAÇO WHILE
// int soma = 0, numero = 0;
// do
// {
//     Console.WriteLine("Digite um número: (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());
//     soma += numero;
// } while (numero != 0);
// Console.WriteLine($"A soma dos numero digitados é: {soma}");
// //*****LAÇO WHILE
// int numeroWhile = 5;
// int contadorWhile = 1;
// while (contadorWhile <= 10)
// {
//     Console.WriteLine($"{numeroWhile} * {contadorWhile} = {numeroWhile * contadorWhile}");
//     contadorWhile++;
//     break; // Para sair do fluxo de execução
// }
// // *****LAÇO FOR 
// int numeroFor = 5;
// for (int contador = 1; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numeroFor} * {contador} = {numeroFor * contador}");
// }

// // ############################# INCREMENTO E DECREMENTO
// //*****INCREMENTO
// int numeroIncremento = 10;
// Console.WriteLine(numeroIncremento); // Retorno: 10
// numeroIncremento = numeroIncremento + 1;
// Console.WriteLine(numeroIncremento); // Retorno: 11
// numeroIncremento += 1;
// Console.WriteLine(numeroIncremento); // Retorno: 12
// numeroIncremento++;
// Console.WriteLine(numeroIncremento); // Retorno: 13
// //*****DECREMENTO
// int numeroDecremento = 20;
// Console.WriteLine(numeroDecremento); // Retorno: 20
// numeroDecremento = numeroDecremento - 1;
// Console.WriteLine(numeroDecremento); // Retorno: 19
// numeroDecremento -= 1;
// Console.WriteLine(numeroDecremento); // Retorno: 18
// numeroDecremento--;
// Console.WriteLine(numeroDecremento); // Retorno: 17

// // ############################# CALCULADORA 
// Calculadora calc = new Calculadora();
// calc.Somar(10, 5);
// calc.Subtrair(50, 30);
// calc.Multiplicar(40, 80);
// calc.Dividir(41, 41);
// calc.Potencia(3, 3);
// calc.Seno(32);
// calc.Coseno(54);
// calc.Tangente(12);
// calc.RaizQuadrada(25);

// // ############################# CONDICIONAIS IF E SWITCH
// string letra = Console.ReadLine();
// // *****IF
// Console.WriteLine("Digite uma letra");
// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("É uma vogal!");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal!");
// }
// // *****SWITCH CASE
// Console.WriteLine("Digite uma letra");
// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("É uma vogal!");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal!");
//         break;
// }

// // ############################# CONVERSÃO DE VARIÁVEIS - CAST - CASTING
// // *****CONVERSÃO SEM EXCEPTION
// string valorInvalido = "95c";
// int numeroValido = 50;
// int.TryParse(valorInvalido, out numeroValido); // Se invalido atribui 0
// Console.WriteLine(numeroValido);
// // *****CONVERSÃO "CAST" IMPLÍCITO
// int numeroInteiro = 82;
// long numeroLong = numeroInteiro;
// double numeroDouble = numeroLong;
// Console.WriteLine(numeroDouble);
// // *****CONVERSÃO "CAST" EXPLÍCITA
// int numero = 54;
// string stringConvertida = numero.ToString(); // Todos os tipos possuem o método .ToString() herdado do OBJECT.
// Console.WriteLine(stringConvertida);
// int numeroConvertido;
// numeroConvertido = Convert.ToInt32("5");
// numeroConvertido = Convert.ToInt32(null); // Convert aceita nulo
// numeroConvertido = int.Parse("10"); // Parse não aceita nulo
// Console.WriteLine(numeroConvertido);

// // ############################# TRABALHANDO COM DATAS
// DateTime dataAtual = DateTime.Now;
// //dataAtual = dataAtual.AddDays(5); // Adicionando 5 dias
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy")); // Imprimindo só dia mês e ano
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm")); // Imprimindo dia mês ano hora minuto
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm:ss")); // Imprimindo TUDO dia mês ano hora minuto segundos

// // ############################# EXPLORANDO VARIÁVEIS
// string introducao = "Explorando tipos de variáveis";
// int quantidade = 10;
// double altura = 1.80; // RETORNA: 1,8
// decimal preco = 1.80M; // RETORNA: 1,80 Atencção para o M abrigatório quando atribuição de decimal
// bool condicao = true; // No C# não se pode atribuir 1 e 0 implicitamente para boolean
// Console.WriteLine(introducao);
// // *****INTERPOLAÇÃO DE STRINGs
// Console.WriteLine("Valor da variável quantidade é: " + quantidade);
// Console.WriteLine($"Valor da variável altura é: {altura}");
// Console.WriteLine(string.Format("Valor da variável preço é: {0}", preco));
// Console.WriteLine("Valor da variável condiçao é: " + condicao);

// // ############################# INSTÂNCIANDO A CLASSE PESSOA E ATRIBUINDO VALORES PARA AS PROPRIEDADES
// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Arthur";
// pessoa1.Idade = 22;
// pessoa1.Apresentar();

