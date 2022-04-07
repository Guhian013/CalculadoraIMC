Console.Write("\nEntre com o seu nome: ");
string nome = Console.ReadLine()!;

Console.Write("Entre com a sua altura. Ex: 1,65: ");
double altura = Convert.ToDouble(Console.ReadLine());

Console.Write("Entre com o seu peso em kg. Ex: 67,5: ");
double peso = Convert.ToDouble(Console.ReadLine());

Individuo i1 = new Individuo(nome, peso, altura);

if (altura <= 00.00 || peso <= 00.00)
{
    Console.Clear();
    Console.WriteLine("\nPor favor, não insira valores negativos ou nulos!");
}
else
{
    Console.Clear();
    Console.WriteLine($"\n{i1.Nome}, sua altura é {i1.Altura} e seu peso {i1.Peso}");
    Console.WriteLine($"Seu IMC é {i1.IMC}, {i1.verificarIMC()}");
    Console.WriteLine(i1.PesoIdeal());
}