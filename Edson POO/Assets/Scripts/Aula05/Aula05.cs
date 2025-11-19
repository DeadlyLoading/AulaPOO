using JetBrains.Annotations;
using UnityEngine;

public class Aula05 : MonoBehaviour
{

    public int flechas = 20;

     void Start()
    {
        //Player player = new Player("He´roi", 100);
        //Enemy enemy = new Enemy("Monstro", 80, 15);

        //player.gritar();
        //enemy.reclamar();
        Arqueiro a = new Arqueiro("Yasmin", 100);
        a.AtirarFlecha();
        a.receberDano(10);

    }

    
}
