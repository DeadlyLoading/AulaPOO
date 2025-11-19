using UnityEngine;

public class Escudo
{
    private string nome;
    private int danoExtra;

    public Escudo(string nome, int danoExtra)
    {
        this.nome = nome;
        this.danoExtra = danoExtra;
    }
    public int getDefesaExtra()
    {
        return danoExtra;
    }
}
