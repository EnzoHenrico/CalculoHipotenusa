float cateto1 = 0, cateto2 = 0;
double hipotenusa = 0;

Console.WriteLine("Encontre a hipotenusa pelo valor dos catetos.\n");

do
{
    Console.Write("Digite o valor do primeiro cateto: ");
    cateto1 = float.Parse(Console.ReadLine());

    if (cateto1 <= 0)
    {
        Console.WriteLine("\nCatetos devem ser positivos, tente novamente.\n");
    }

} while (cateto1 <= 0);

do
{
    Console.Write("Digite o valor do segundo cateto: ");
    cateto2 = float.Parse(Console.ReadLine());

    if (cateto2 <= 0)
    {
        Console.WriteLine("\nCatetos devem ser positivos, tente novamente.\n");
    }

} while (cateto2 <= 0);

hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

Console.WriteLine($"\nHipotenusa = {hipotenusa:0.00}");