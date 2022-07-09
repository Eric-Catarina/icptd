using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstroiTorreClique : MonoBehaviour
{
    [SerializeField] private GameObject torrePrefab;
    private bool Clicou()
    {
        return Input.GetMouseButtonDown(0);
    }

    private Vector3 posicaoDoElemento;
    void Start()
    {
        
    }
    
    void Update()
    {
        if (Clicou())
        {
            Debug.Log("clicou");
            
            Vector3 pontoDoClique = Input.mousePosition;
            Ray raioDaCamera = Camera.main.ScreenPointToRay (pontoDoClique);
            
            float comprimentoMaximo = 1000000.0f;
            
            Physics.Raycast (raioDaCamera, out RaycastHit infoDoRaio, comprimentoMaximo);
            
            if (infoDoRaio.collider)
            {
                posicaoDoElemento = infoDoRaio.point;
                posicaoDoElemento.y += 0;
                Instantiate(torrePrefab, posicaoDoElemento, Quaternion.identity);
            }
        }
    }
}
