using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorDeCruzamento : MonoBehaviour
{
    [SerializeField] private Player jogador;
    private void OnTriggerEnter(Collider objetoColidido)
    {
        Destroy(objetoColidido.gameObject);
        jogador.perdeVida();
        
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
