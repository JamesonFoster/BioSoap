using UnityEngine;

public class BubbleSlamShot : MonoBehaviour
{
    
    [SerializeField]
    private GameObject projectilePrefab;
    // Start is called before the first frame update

    [SerializeField]
    private float speed = 10.0f;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Debug.Log("FireBubble");
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(-Vector3.forward * speed * Time.deltaTime);
        }
    }
}