using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BovidSpawner : MonoBehaviour
{
    public GameObject Bovid;
    private float lastSpawned  = 0;
    public float spawnDelay = 30;
    public float spawnsub = 3;
    float gametime = 0;
    // Update is called once per frame
    void Update()
    {
        lastSpawned += (Time.deltaTime);
        gametime += (Time.deltaTime);
        if (gametime >= 60)
        {
            spawnDelay -= spawnsub;
            gametime = 0;
        }
        if (spawnDelay < spawnsub)
        {
            spawnDelay = spawnsub;
        }
        if (lastSpawned >= spawnDelay)
        {
            Instantiate(Bovid, transform.position, transform.rotation);
            Debug.Log("BovidSpawned");
            lastSpawned = 0;
        }    
    }
}