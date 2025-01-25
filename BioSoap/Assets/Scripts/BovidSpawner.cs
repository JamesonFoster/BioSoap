using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject Bovid;
    private float lastSpawned  = 0;
    public float spawnDelay = 10;
    // Update is called once per frame
    void Update()
    {
        lastSpawned += (Time.deltaTime);
        if (lastSpawned >= spawnDelay)
        {
            Instantiate(Bovid, transform.position, transform.rotation);
            Debug.Log("BovidSpawned");
            lastSpawned = 0;
        }    
        
    }
}
