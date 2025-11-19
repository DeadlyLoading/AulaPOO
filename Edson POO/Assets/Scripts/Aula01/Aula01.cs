using Assets;
using UnityEngine;

public class Aula01 : MonoBehaviour
{
    void Start()
    {
        Pessoa p1 = new Pessoa();
        p1.receberUmNome("Yasmin");
        

        Pessoa p2 = new Pessoa();
        p2.receberUmNome("Edson");

        Debug.Log(p2.perguntarONome(p1));

        
    }

    void Update()
    {
        
    }
}
