string situacao;
double imc;

Console.Write("\nEntre com o seu nome: ");
string nome = Console.ReadLine()!;

Console.Write("Entre com a sua altura. Ex: 1,65: ");
float altura = Convert.ToSingle(Console.ReadLine());

Console.Write("Entre com o seu peso em kg. Ex: 67,5: ");
float peso = Convert.ToSingle(Console.ReadLine());

String PesoIdeal() 
{
    double normalMinimo = Math.Pow(altura,2) * 18.5;
    double normalMaximo = Math.Pow(altura,2) * 25;

    if (imc < 18.5) {
        return $"Por isso você precisa ganhar {Math.Round(normalMinimo - peso,2)}kg para atingir o peso normal.";
    } else if (imc > 25)
    {
        return $"Por isso você precisa perder {Math.Round(peso - normalMaximo,2)}kg para atingir o peso normal.";
    } else {
        return "";
    }
}

if (altura <= 00.00 || peso <= 00.00)
{
    Console.Clear();
    Console.WriteLine("\nPor favor, não insira valores negativos ou nulos!");
}
else
{
    imc = peso / (altura * altura);

    verificarIMC();

    Console.Clear();
    Console.WriteLine($"\n{nome}, sua altura é {altura} e seu peso {peso}");
    Console.WriteLine($"Seu IMC é {Math.Round(imc,2)}, isso significa que você está {situacao}");
    Console.WriteLine(PesoIdeal());
}

string verificarIMC() 
{
    if (imc < 17) 
    {
        return situacao = "muito abaixo do peso.";
    } 
    else if (imc >= 17 && imc < 18.50)
    {
        return situacao = "abaixo do peso.";
    }
    else if (imc >= 18.50 && imc < 25)
    {
        return situacao = "com um peso normal.";
    }
    else if (imc >= 25 && imc < 30)
    {
        return situacao = "acima do peso.";
    }
    else if (imc >= 30 && imc < 35)
    {
       return situacao = "com um nível de obesidade I.";
    }
    else if (imc >= 35 && imc < 40)
    {
        return situacao = "com um nível de obesidade II (severa).";
    }
    else if (imc > 40)
    {
        return situacao = "com um nível de obesidade III (mórbida).";
    }
    else
    {
        throw new Exception("Erro!!");
    }
}