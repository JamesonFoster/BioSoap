using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JermanySpawner : MonoBehaviour
{
    public GameObject Jermany;
    private float lastSpawned  = 0;
    public float spawnDelay = 10;
    // Update is called once per frame
    void Update()
    {
        lastSpawned += (Time.deltaTime);
        if (lastSpawned >= spawnDelay)
        {
            Instantiate(Jermany, transform.position, transform.rotation);
            Debug.Log("JermanySpawned");
            lastSpawned = 0;
        }    
    }
}