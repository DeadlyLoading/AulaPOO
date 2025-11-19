using Unity.VisualScripting;
using UnityEngine;


//public enum TipoPersonagem
//{
//    Guerreiro,
//    Mago,
//    Arqueiro,
//}




public class Mago
{
    private string nome;
    private int vida;
    private int mana;

}
    

public abstract class Personagem :  IPersonagem
{
    //private TipoPersonagem tipo;
    protected string nome;
    protected int vida;

    

    public Personagem(string nome, int vida)
    {
        this.nome = nome;
        if (vida > 100)
        {
            this.vida = 100;
        }
        this.vida = vida;
    }
    


    public virtual void gritar ()
    {
        Debug.Log("Ahhhh");
    }
    //public TipoPersonagem GetTipoPersonagem()
    //{
    //    return tipo;
    //}
    //public void SetTipoPersonagem(TipoPersonagem tipo)
    //{
    //    this.tipo= tipo;
    //}

    public string GetNome()
    {
        return nome;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public int GetVida()
    {
        return vida;
    }
    
    public void SetVida(int vida)
    {
        this.vida = vida;
    }
    public abstract void ReceberDano(int dano);

    public void conversar(string mensagem)
    {
     Debug.Log($"{nome}  diz: {mensagem}");
    }
}
