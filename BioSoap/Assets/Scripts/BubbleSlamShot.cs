using UnityEngine;

public class BubbleSlamShot : MonoBehaviour
{
    
    [SerializeField]
    private GameObject projectilePrefab;
    // Start is called before the first frame update

    [SerializeField]
    private float speed = 10.0f;

    public float buttonDelay = 1;
    float lastButtonTime = 0;

    [SerializeField]
    private Transform origin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        lastButtonTime += (Time.deltaTime);
        if (lastButtonTime >= buttonDelay)
        {
            if(Input.GetButtonDown("Fire1"))
            {
                Instantiate(projectilePrefab, origin.position, transform.rotation);
                Debug.Log("FireBubble");
                lastButtonTime = 0;
            }
        }

            /*if(Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.forward * speed * Time.deltaTime);
            }

            if(Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(-Vector3.forward * speed * Time.deltaTime);
            }
            */
            
    }

}