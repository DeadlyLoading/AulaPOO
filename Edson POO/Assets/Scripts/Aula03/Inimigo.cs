using JetBrains.Annotations;
using UnityEngine;

public class Inimigo
{
    private string nome;
    private int vida;
    private static int quantInimigos = 0;

   
    public Inimigo(string nome, int vida)
    {
        this.nome = nome;
        this.vida = vida;
        quantInimigos++;
    }
    public Inimigo(string nome)
    {
        this.nome = nome;
        quantInimigos++;
    }
    public Inimigo()
    {
        quantInimigos++;
    }

    public  static int GetContarInimigos()
    {
        return quantInimigos;
    }

    public Inimigo(int vida)
    {
        this.vida = vida;
    }

    public string getNome()
    {
        return nome;
    }
    public void setNome(string nome)
    {
        this.nome = nome;
    }
    public int getVida()
    {
        return vida;
    }
    public void setVida(int vida)
    {
        this.vida = vida;
    }

   
   
}
