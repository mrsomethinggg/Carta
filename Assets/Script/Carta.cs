using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carta : MonoBehaviour
{
    int números;
    int naipes;
    string nomedosnaipes;
    string figuras;

     // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Olá humano, vou sortear uma carta.");
        Debug.Log("Carrega no espaço para sair a carta.");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           números = Random.Range(2, 15);
            naipes = Random.Range(1, 5);

            if (naipes == 1)
            {
                nomedosnaipes = "Copas";
            }
            if (naipes == 2)
            {
                nomedosnaipes = "Paus";
            }
            if (naipes == 3)
            {
                nomedosnaipes = "Ouros";
            }
            if (naipes == 4)
            {
                nomedosnaipes = "Espadas";
            }

            if (números == 11)
            {
                figuras = "Ás";
            }

            if (números == 12)
            {
                figuras = "Rei";
            }

            if (números == 13)
            {
                figuras = "Valete";
            }

            if (números == 14)
            {
                figuras = "Damas";
            }

            if (números <= 10)
                Debug.Log("A carta que saiu é " + números + " de " + nomedosnaipes);

            else
                Debug.Log("A carta que saiu é " + figuras + " de " + nomedosnaipes);

        }
    }
}
