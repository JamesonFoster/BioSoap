using UnityEngine;

public class BubBomThrow : MonoBehaviour
{

    [SerializeField]
    private GameObject projectilePrefab;
    // Start is called before the first frame update

    [SerializeField]
    private float speed = 5.0f;

    public float buttonDelay = 7;
    float lastButtonTime = 0;
    public float maxSpread = 0.2f;

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
            if (Input.GetButton("Fire1"))
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