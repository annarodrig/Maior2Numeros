double primeiroNumero, segundoNumero;

Console.Write("Digite o primeiro número..: ");
primeiroNumero = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite o segundo número...: ");
segundoNumero = Convert.ToDouble(Console.ReadLine()!);

if (primeiroNumero > segundoNumero)
{
    Console.WriteLine($"O maior número é {primeiroNumero}");
}
else
{
    Console.WriteLine($"O maior número é {segundoNumero}");
}