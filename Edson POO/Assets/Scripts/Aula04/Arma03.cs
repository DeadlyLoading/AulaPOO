using UnityEngine;

public abstract class Arma03
{
    private string nome;
    private int dano;
    
   
    public  Arma03(string nome, int dano)
    {
        this.nome = nome;
        this.dano = dano;
    }

    public abstract void usar();
    public int getDano()
    {
        return dano;
    }
    public string getNome()
    {
        return nome;
    }
   
}
