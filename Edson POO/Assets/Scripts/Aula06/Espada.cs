using UnityEngine;

public class Espada : Arma03, IArmaDeCorte
{
    public Espada(string nome, int dano) : base(nome, dano)
    {
    }

    public void Cortar()
    {
        Debug.Log("Fatiador");
    }

    public override void usar()
    {
        Cortar();
    }


}
