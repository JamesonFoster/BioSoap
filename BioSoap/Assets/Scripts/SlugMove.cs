using UnityEngine;

public class SlugMove : MonoBehaviour
{
    public float slidTime = 5;
    public float shootTime = 3;
    public float speed = 1;
    public GameObject soapy;
    float timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            var step = speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, soapy.transform.position, step);
            transform.LookAt(soapy.transform.position);
            transform.Rotate(90, 0, 0, Space.Self);
    }
}
