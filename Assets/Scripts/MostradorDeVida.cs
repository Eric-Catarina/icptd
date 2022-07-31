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
    [SerializeField] private GeradorDeInimigos spawnDeInimigos;
    
    
    void Start()
    {
        Enemy.inimigosMortos = 0;
        
    }
    
    void Update()
    {
        campoTextoTextMeshPro.text = ("Vida: " + jogador.retornaPontosDeVida())
        + "\n\nTorres restantes: " + scriptQuantidadeTorres.retornaTorresRestantes()
        +"\n\nInimigos na Wave: " + spawnDeInimigos.RetornaInimigosNaWave()
        +"\n\nInimigos Mortos: "+Enemy.RetornaInimigosMortos();
        
        
    }
}
