using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonsManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource somMorte;
    public void tocaSomMorte()
    {
        somMorte.Play();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
