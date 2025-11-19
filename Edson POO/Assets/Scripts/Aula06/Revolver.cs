using UnityEngine;

public class Revolver : Arma03, IArmaFogo
{
    public Revolver(string nome, int dano) : base(nome, dano)
    {
    }

    public void Atirar()
    {
        Debug.Log("Balas de festim");
    }

    public override void usar()
    {
        Atirar();
    }
}
