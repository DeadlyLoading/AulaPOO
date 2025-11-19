using UnityEngine;

public class atividade1901 : MonoBehaviour
{
    void Start()
    {
        Player player = new Player("Jovem", 100);

        Espada espada = new Espada("Adamas", 35);
        Revolver revolver = new Revolver("Ebony", 130);

        player.setArma(espada);
        player.setArma(espada);

        Debug.Log()
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
