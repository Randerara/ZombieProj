using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject coin;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void SpawnCoin()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("SpawnCoin", Random.Range(1,3));
    }
}
