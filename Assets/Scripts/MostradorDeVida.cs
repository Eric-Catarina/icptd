using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MostradorDeVida : MonoBehaviour
{
    
    
    [SerializeField]
    private TextMeshProUGUI campoTextoTextMeshPro;
    [SerializeField] private Player jogador;
    [SerializeField] private ConstroiTorreClique scriptQuantidadeTorres;
    
    
    void Start()
    {
        
        
    }
    
    void Update()
    {
        campoTextoTextMeshPro.text = ("Vida: " + jogador.retornaPontosDeVida()) + "\nTorres restantes: " + scriptQuantidadeTorres.retornaTorresRestantes();
        
        
    }
}
