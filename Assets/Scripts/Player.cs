using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int pontosDeVida;
    [SerializeField] private GameObject gameover;
    public int retornaPontosDeVida()
    {
        return pontosDeVida;
    }

    public bool estaVivo()
    {
        return pontosDeVida > 0;
    }

    public void perdeVida()
    {
        pontosDeVida--;
    }
    void Start()
    {
        pontosDeVida = 5;
    }

    
    void Update()
    {
        if (!estaVivo())
        {
         gameover.gameObject.SetActive(true);   
        }
        
    }
}
