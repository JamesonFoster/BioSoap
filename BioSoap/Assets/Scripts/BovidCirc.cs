using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BovidCirc : MonoBehaviour
{
    float timeCounter = 0;
    public float agroTimer = 30;
    float checker = 0;
    public float speed = 2;
    public GameObject soapy;


    void Update()
    {
        if (checker <= agroTimer)
        {
            timeCounter += Time.deltaTime;
            float x = Mathf.Sin(timeCounter);
            float y = 10;
            float z = Mathf.Sin(timeCounter);
            transform.position = new Vector3(x, y, z);
            checker += Time.deltaTime;
        }
        else
        {
            var step = speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, soapy.transform.position, speed);
        }

    }
}
