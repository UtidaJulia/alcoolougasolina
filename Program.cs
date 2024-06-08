double Etanol ;
double Gasolina ;
double razao ;
double percentualIdeal ;

double CalcularRazaoPreco (double Etanol,double Gasolina)
{
    return Etanol / Gasolina * 100;
}

bool ValeAPenaAbastecerComGasolina(double razao)
{
    percentualIdeal = 73;
    return razao >= percentualIdeal;
}

Console.Write("Digite o preço do Etanol: ");
Etanol = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.Write("Digite o preço do Gasolina: ");
Gasolina = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

razao = CalcularRazaoPreco(Etanol,Gasolina);

Console.WriteLine($"Razão entre os preços é {razao:F2}% ");

if
(ValeAPenaAbastecerComGasolina(razao))
{
    Console.WriteLine("Abastecer com Gasolina ");
}
else
{
    Console.WriteLine("Abastecer com Etanol ");
}