//using NUnit.Framework;
//using System.Collections.Generic;
//using UnityEngine;

//public class Aula04 : MonoBehaviour
//{
//    void Start()
//    {
//        //exemploArrayList();

//        //Aula de associção de objetos

//        Player player = new Player("Herói", 100);

//        //Isso de baixo se chama instanciar :)
//       Enemy inimigo = new Enemy("Urso", 50, 15);
//        Arma03 espada = new Arma03("Espada Longa", 20);
//        Armadura armadura = new Armadura("Armadura de couro", 5);
//        Escudo escudo = new Escudo("Escudo de Madeira", 3);
//        player.setArma(espada);
//        player.setArmadura( armadura);
//        player.setEscudo(escudo);
//        player.Atacar(inimigo, espada);
//        inimigo.Atacar(player);
//        player.Atacar(inimigo, espada);
//        inimigo.Atacar(player);
//        Arma03 arco = new Arma03("Arco e flecha", 15);
//        player.setArma(arco);



//    }

//    void exemploArrayList()
//    {
//        //Array e Lista
//        //Arrray é necessário definir a quantidade de itens nele
//        //Lista não possui limite.
//        int[] numeros = new int[3];
//        numeros[0] = 10;
//        numeros[1] = 20;
//        numeros[2] = 30;

//        //Estrutura de repetição: For, While e foreach
//        Debug.Log("Primeira posição do Array: " + numeros[0]);
//        for (int i = 0; i < numeros.Length; i++)
//        {
//            Debug.Log("Posição " + i + " do array: " + numeros[i]);
//        }
//        foreach (int numero in numeros)
//        {
//            Debug.Log("Número do array: " + numero);
//        }

//        //Lista
//        List<string> frutas = new List<string>();
//        frutas.Add("Maça");
//        frutas.Add("Banana");
//        frutas.Add("Laranja");
//        Debug.Log("Primeira fruta da lista: " + frutas[0]);
//        frutas.Remove("Banana");
//        Debug.Log("Quantidade de frutas: " + frutas.Count);
//        for (int i = 0; i < frutas.Count; i++)
//        {
//            Debug.Log("Fruta " + (i + 1) + "da lista: " + frutas[i]);
//        }
//        foreach (string fruta in frutas)
//        {
//            Debug.Log("Fruta da lista :" + frutas);
//        }
//    }

    
//}
