using JetBrains.Annotations;
using UnityEngine;

public class Arqueiro : Personagem
{
    public int flechas = 20;
    public int dano = 15;
    
    public Arqueiro(string name, int vida) : base(name, vida)
    {
            
    }
    public void AtirarFlecha()
    {


        if (this.flechas == 0)
        {
            Debug.Log("Não há mais flechas");
        }
        else
        {
            this.flechas = this.flechas - 1;
            Debug.Log("disparei uma flecha");
        }
    }

    public void receberDano(int dano)
    {

        if (this.vida > 0)
        {
            Debug.Log("morreu");
        }
        else
        {
            this.vida = this.vida - dano;
        }
       
       
       
    }

    public override void ReceberDano(int dano)
    {
        throw new System.NotImplementedException();
    }
}
