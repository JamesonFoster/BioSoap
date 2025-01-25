using UnityEngine;

public class BubbleSlamShot : MonoBehaviour
{
    
    [SerializeField]
    private GameObject projectilePrefab;
    // Start is called before the first frame update

    [SerializeField]
    private float speed = 10.0f;

    public float timer = 5;
    private float cool = 0;

    [SerializeField]
    private Transform origin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cool <= timer)
        {
            if(Input.GetButtonDown("Fire1"))
            {
                Debug.Log("FireBubble");
                Instantiate(projectilePrefab, origin.position, transform.rotation);
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
        cool += (Time.deltaTime);
    }
}