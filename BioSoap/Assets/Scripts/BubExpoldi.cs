using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BubExpoldi : MonoBehaviour
{
    float timer = 0;
    //public GameObject ExploTrigger;
    private void OnTriggerEnter (Collider other)
    {
        Debug.Log("Hit Object");

        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
       
    }
    void Update()
    {
        timer += (Time.deltaTime);
        if (timer >= 20)
        {
            Destroy(gameObject);
        }
    }
}
