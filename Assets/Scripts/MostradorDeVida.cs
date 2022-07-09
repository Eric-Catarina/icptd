using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MostradorDeVida : MonoBehaviour
{
    
    
    [SerializeField]
    private TextMeshProUGUI campoTextoTextMeshPro;
    [SerializeField] private Player jogador;
    
    void Start()
    {
        
        
    }
    
    void Update()
    {
        campoTextoTextMeshPro.text = "Vida: " + jogador.retornaPontosDeVida() ;
    }
}
