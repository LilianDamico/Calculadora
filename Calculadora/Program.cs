// Calculadora
int op;
Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.Clear();
Console.WriteLine("***************************************************");
Console.WriteLine("                 Escolha uma das opções:           ");
Console.WriteLine("                 1 - Soma:                         ");
Console.WriteLine("                 2 - Subtra~ção:                   ");
Console.WriteLine("                 3 - Multiplicação:                ");
Console.WriteLine("                 4 - Divisão:                      ");
Console.WriteLine("                 Opção Inválida.                   ");
Console.WriteLine("***************************************************");
op = Convert.ToInt32(Console.ReadLine());
switch (op)
{
    case 1:
        int n, n1, r1;
        Console.WriteLine("Informe o valor de n: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o valor de n1: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        r1 = n + n1;
        Console.WriteLine("O resultado da Soma é: ", + r1);
        break;
    case 2:
        int a, b, r2;
        Console.WriteLine("Informe o valor de a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o valor de b; ");
        b = Convert.ToInt32(Console.ReadLine());
        r2 = a - b;
        Console.WriteLine("O valor da Subtração é " + r2);
        break;
    case 3:
        int m1, m2, r3;
        Console.WriteLine("Informe o valor do Multiplicador: ");
        m1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o Multiplicando: ");
        m2 = Convert.ToInt32(Console.ReadLine());
        r3 = m1 * m2;
        Console.WriteLine("O valor do Produto é: " + r3);
        break;
    case 4:
        int d1, d2, q;
        Console.WriteLine("Informe o valor do dividendo: ");
        d1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o valor do divisor: ");
        d2 = Convert.ToInt32(Console.ReadLine());
        q = d1 / d2;
        Console.WriteLine("O valor do quociente é: " + q);
        break;
        default:
        Console.WriteLine("Tente novamente.");
        break;

}
Console.ReadLine();
//Fim