using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UI_Change : MonoBehaviour

{
   public Canvas weaponIcon;

    private RawImage image;
    private void Start()
    {
     image = weaponIcon.GetComponent<RawImage>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.U))
        {
            // toggle visibility:
        
        }
    }

}
