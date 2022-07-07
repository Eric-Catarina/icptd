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
            
            float comprimentoMaximo = 10000000.0f;
            
            Physics.Raycast (raioDaCamera, out RaycastHit infoDoRaio, comprimentoMaximo);
            
            if (infoDoRaio.collider)
            {
                Vector3 posicaoDoElemento = infoDoRaio.point;
                Instantiate(torrePrefab, posicaoDoElemento, Quaternion.identity);
            }
        }
    }
}
