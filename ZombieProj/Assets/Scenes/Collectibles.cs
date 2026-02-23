using System;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;
using Random = UnityEngine.Random;


public class Collectibles : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    
    void OnTriggerEnter (Collider other) 
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
