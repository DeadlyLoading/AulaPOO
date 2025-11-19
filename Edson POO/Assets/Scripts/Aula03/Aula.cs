using UnityEngine;

public class Aula : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Inimigo goblin = new Inimigo("Goblin",100);
        Debug.Log("Inimigo: " + goblin.getNome() + " Vida: " + goblin.getVida());

        Inimigo semNome = new Inimigo();
        semNome.setVida(50);
        semNome.setNome("Sem Nome");
        Debug.Log("Inimigo: " + semNome.getNome() + " Vida: " + semNome.getVida());
        
        Inimigo inimigo = new Inimigo("jorge"); //É NOME!!
        Debug.Log("o nome do inimigo é " + inimigo.getNome());


       Arma faca = new Arma();
        Debug.Log(faca.Atacar());
        Debug.Log(faca.Atacar(100));
        Debug.Log(faca.Atacar("Ataques cortantes"));

        Debug.Log(Inimigo.GetContarInimigos() + " Inimigos foram encontrados");
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
