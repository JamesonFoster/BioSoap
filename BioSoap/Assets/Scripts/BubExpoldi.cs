using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BubExpoldi : MonoBehaviour
{
    float timer = 0;
    AudioManager am;
    public AudioSource pop;
    //public GameObject ExploTrigger;
    private void Start()
    {
        am = FindObjectOfType<AudioManager>();
        if (am == null) Debug.LogError("_audioManager is NULL");
    }
    private void OnTriggerEnter (Collider other)
    {
        Debug.Log("Hit Object");

        if (other.gameObject.CompareTag("Enemy"))
        {
            am.PlayPOP();
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Trash"))
        {
            am.PlayPOP();
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("E1"))
        {
            am.PlayPOP();
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("E2"))
        {
            am.PlayPOP();
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
