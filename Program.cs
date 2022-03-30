Console.Write("Entre com o seu nome: ");
string nome = Console.ReadLine();

Console.Write("Entre com a sua altura. Ex: 1,65: ");
float altura = Convert.ToSingle(Console.ReadLine());

Console.Write("Entre com o seu peso em kg. Ex: 67,5: ");
float peso = Convert.ToSingle(Console.ReadLine());

double imc = peso / (altura * altura);

Console.WriteLine($"\n{nome}, sua altura é {altura} e seu peso {peso}");
Console.WriteLine($"Seu IMC é {imc}");