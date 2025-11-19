using UnityEngine;

public class PersonagemRPG1 : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PersonagemRPG personagemRPG = new PersonagemRPG("Potato",100,150);
        Debug.Log("Nome: " + personagemRPG.GetNome());
        Debug.Log(personagemRPG.GetVida());
        Debug.Log(personagemRPG.GetMana());

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
