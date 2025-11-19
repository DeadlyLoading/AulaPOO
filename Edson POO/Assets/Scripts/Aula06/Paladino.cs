using UnityEditor;
using UnityEngine;

public class Paladino : Personagem
{
    public Paladino(string nome, int vida) : base(nome, vida)
    {
    }

    public override void ReceberDano(int dano)
    {
        this.vida -= dano;
    }
}
