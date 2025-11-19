using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PersonagemRPG
{
    private string nome;
    private int vida;
    private int mana;

    public PersonagemRPG(string nome, int vida, int mana)
    {
        this.nome = nome;
        this.vida = vida;
        this.mana = mana;
    }
    public void SetNome(string nome)
    {
        this.nome = nome;
    }
    public void SetVida(int vida)
    {
       this.vida =(int)vida;
    }
    public void SetMana(int mana)
    {
        this.mana = (int)mana;
    }

    public string GetNome()
    {
        return nome;
    }

    public int GetVida()
    {
        return vida;
    }

    public int GetMana()
    {
        return mana;
    }
   

}
