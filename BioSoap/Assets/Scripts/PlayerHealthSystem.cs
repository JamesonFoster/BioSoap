using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PlayerHealthSystem : MonoBehaviour
{
        public float playerhealth = 100;
        public bool isdead = false;
        public float exploDamage = 15;
        public float munchDamage = 3;
        public float invisframes = 1;
        float timer = 0;
    public GameObject ded;



    private void OnTriggerEnter(Collider other)
    {
        timer += (Time.deltaTime);
        if (timer >= invisframes)
        {
            if (other.gameObject.CompareTag("Boom"))
            {
                playerhealth -= exploDamage;
                timer = 0;
            }
            if (other.gameObject.CompareTag("E1"))
            {
                playerhealth -= munchDamage;
                timer = 0;
            }
            if (other.gameObject.CompareTag("DeathBorder"))
            {
                playerhealth -= munchDamage * 5000;
                isdead = true;
                Debug.Log("d");
            }
            if (other.gameObject.CompareTag("Medi"))
            {
            Destroy(other);
            
            playerhealth += 20;

            if (playerhealth > 100)
            {
                playerhealth = 100;
            }
            }
        
        }
        

        
    }

    void Update()
    {
        if (playerhealth <= 0)
        {
            isdead = true;
        }
        if (isdead == true)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadSceneAsync(2);
        }
    }
}