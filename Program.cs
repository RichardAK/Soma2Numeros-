int n1, n2, resultado; 

Console.WriteLine("Cálculo da soma entre dois números.\n");

Console.Write("digite um número: ");
n1 = Convert.ToInt32(Console.ReadLine()!);

Console.Write("digite um número: ");
n2 = Convert.ToInt32(Console.ReadLine()!);

resultado = n1 + n2 ; 

Console.WriteLine($"\n A soma dos números é: {resultado} ");