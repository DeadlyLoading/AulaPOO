using UnityEngine;

public class Arma
{
   private string arma;
   private int forca;
   private string efeito;

    public string Atacar()
    {
        return "Ataque simples";
    }
    public string Atacar(int forca)
    {
        return "Ataqque com força " + forca;
    }

    public string Atacar(string efeito)
    {
        return "Ataque com efeito: " + efeito;
    }
}
