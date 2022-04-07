public class Individuo
{
    #region Propriedades
    public string? Nome { get; set; }
    public double Peso { get; set; }
    public double Altura { get; set; }
    public double IMC { get => Math.Round(Peso / Math.Pow(Altura,2),2); }
    public double NormalMinimo { get => Math.Pow(Altura,2) * 18.5; }
    public double NormalMaximo { get => Math.Pow(Altura,2) * 25; }
    #endregion

    #region Construtores
    public Individuo()
    {
        Nome = "";
        Peso = 0.0;
        Altura = 0.0;
    }

    public Individuo(String nome, double peso, double altura)
    {
        Nome = nome;
        Peso = peso;
        Altura = altura;
    }
    #endregion

    #region Métodos
    public string verificarIMC() 
    {
        if (IMC < 17) 
        {
            return $"isso significa que você está muito abaixo do peso.";
        } 
        else if (IMC >= 17 && IMC < 18.50)
        {
            return $"isso significa que você está abaixo do peso.";
        }
        else if (IMC >= 18.50 && IMC < 25)
        {
            return $"isso significa que você está com um peso normal.";
        }
        else if (IMC >= 25 && IMC < 30)
        {
            return $"isso significa que você está acima do peso.";
        }
        else if (IMC >= 30 && IMC < 35)
        {
        return $"isso significa que você está com um nível de obesidade I.";
        }
        else if (IMC >= 35 && IMC < 40)
        {
            return $"isso significa que você está com um nível de obesidade II (severa).";
        }
        else if (IMC > 40)
        {
            return $"isso significa que você está com um nível de obesidade III (mórbida).";
        }
        else
        {
            throw new Exception("Erro!!");
        }
    }

    public string PesoIdeal() 
    {
        if (IMC < 18.5) {
            return $"Por isso você precisa ganhar {Math.Round(NormalMinimo - Peso,2)} kg para atingir o peso normal.";
        } else if (IMC > 25)
        {
            return $"Por isso você precisa perder {Math.Round(Peso - NormalMaximo,2)} kg para atingir o peso normal.";
        } else {
            return "";
        }
    }
    #endregion
}