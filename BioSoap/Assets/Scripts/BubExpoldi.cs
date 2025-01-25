using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BubExpoldi : MonoBehaviour
{
    //public GameObject ExploTrigger;

    private void OnTriggerEnter (Collider other)
    {
        Debug.Log("Hit Object");

        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
        
       
    }
}
