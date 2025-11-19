using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class Player : Personagem
{
    private string nome;
    private int vida;

    private List<Arma03> armas = new List<Arma03>();
    private Armadura armadura;
    private Escudo escudo;


    public Player(string nome,int vida) : base(nome, vida)
    {
       
    }
    public void setArma(Arma03 arma)
    {
        armas.Add(arma);
    }
    
    public List<Arma03> getAmras()
    {
        return armas;
    }
    public void setArmadura(Armadura armadura)
    {
        this. armadura = armadura;
    }
    public Armadura GetArmadura()
    {
        return this. armadura;
    }
    public void setEscudo(Escudo escudo)
    {
        this.escudo = escudo;
    }
    public Escudo GetEscudo()
    {
        return this.escudo;
    }
    //public override void ReceberDano(int dano) 
    //{
    //    //Vida -= dano - (defesa da armadura + defesaExtra do escudo)
    //    int defesaTotal = armadura.getDefesa() + escudo.getDefesaExtra();
    //    int danoFinal = dano - defesaTotal;
    //    vida -= danoFinal;
    //    Debug.Log($"{nome} recebeu {danoFinal} de dano após " + $"defesa {defesaTotal} ). Vida restante: {vida} ");
    //}
    public void Atacar(Enemy inimigo, Arma03 arma)
    {
        inimigo.ReceberDano(arma.getDano());
        Debug.Log($"{nome} atacou {inimigo.getNome()} com {arma.getNome()} , causando {arma.getDano()} de dano!");
    }
    public override void gritar()
    {
        Debug.Log("Ehhhh!)");
    }
    public void setNome(string nome)
    {
       this.nome = nome;
    }
    public string getNome()
    {
        return nome;
    }

    public override void ReceberDano(int dano)
    {
        
    }

}
