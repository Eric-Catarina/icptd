using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonsManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource somMorte;
    [SerializeField] private AudioSource somSpawn;
    [SerializeField] private AudioSource somHit;
    public void tocaSomMorte()
    {
        somMorte.Play();
    }

    public void tocaSomSpawn()
    {
        somSpawn.Play();
    }
    
    public void tocaSomHit()
    {
        somHit.Play();
    }

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
