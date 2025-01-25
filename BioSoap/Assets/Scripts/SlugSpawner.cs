using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlugSpawnScript : MonoBehaviour
{
    public GameObject Slug;
    private float lastSpawned  = 0;
    public float spawnDelay = 10;
    // Update is called once per frame
    void Update()
    {
        lastSpawned += (Time.deltaTime);
        if (lastSpawned >= spawnDelay)
        {
            Instantiate(Slug, transform.position, transform.rotation);
            Debug.Log("SlugSpawned");
            lastSpawned = 0;
        }    
    }
}
