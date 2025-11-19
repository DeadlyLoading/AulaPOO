using UnityEngine;

public class Aula03 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Magia fogo = new Magia("bola de fogo",50,"explosao em área");
        
        Magia gelo = new Magia();
        gelo.setNome("raio de gelo");
        gelo.setPoder(40);
        gelo.setDescricao("congela o inimigo");
        Debug.Log(fogo.LancarMagia());
        Debug.Log(gelo.LancarMagia("troll"));

        Debug.Log("Total de magias criadas:" + Magia.getContarMagias());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
