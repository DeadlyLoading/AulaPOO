using UnityEngine;

public class Enemy : Personagem, IPersonagem
{
    
    private int dano;
   

    public Enemy(string nome, int dano, int vida) : base(nome,vida)
    {
       
        this.dano = dano;
      
    }
    public void Atacar(Player player)
    {
        player.ReceberDano(dano);
        Debug.Log($" {nome} atacou {player.getNome()} , causando {dano} de dano ");
    }
    public override void ReceberDano(int dano) 
    {
        vida -= dano;
        Debug.Log($"{nome} recebeu {dano} de dano. " + $"Vida restante: {vida}");

        if(vida <= 0)
        {
            Debug.Log($"{nome} foi derrotado!");
        }
    }
    public  string getNome()
    {
        return nome;
    }
   
    public void reclamar()
    {
        Debug.Log("CHega!!!");
    }

    public void conversar(string mensagem)
    {
        throw new System.NotImplementedException();
    }

 
}
