using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
	Transform cam;
    public float base_speed = 3.0f;
    public float max_speed = 6.0f;
    private float current_speed;
    public Rigidbody rb;
    public bool onground = true;
    private void Start()
	{
		cam = Camera.main.transform;
        current_speed = base_speed;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            onground = true;
        }

    }
        void Update()
	{
        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadSceneAsync(0); 
        }
        if (Input.GetKey(KeyCode.W) && current_speed < max_speed)
        {
            current_speed += 1 * Time.deltaTime;
        }
        else if (!Input.GetKey(KeyCode.W) && current_speed > base_speed)
        {
            current_speed -= 1 * Time.deltaTime;
        }

        float translation = Input.GetAxis("Vertical") * current_speed;
        float strafe = Input.GetAxis("Horizontal") * current_speed;
        translation *= Time.deltaTime;
        strafe *= Time.deltaTime;

        transform.Translate(strafe, 0, translation);

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;

        if (Input.GetKey("space") && onground == true)
        {
            rb = GetComponent<Rigidbody>();
            rb.AddForce(0, 5, 0, ForceMode.Impulse);
            onground = false;
        }
    }
}
