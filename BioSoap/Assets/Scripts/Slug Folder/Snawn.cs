using UnityEngine;

public class Snawn : MonoBehaviour
{
    public float Countdown = 5;
    float timer = 0;
    public GameObject thingToSpawn;

    [SerializeField]
    private Transform origin;
    // Update is called once per frame
    void Update()
    {
        timer += (Time.deltaTime);
        if (timer >= Countdown)
        {
            Instantiate(thingToSpawn, origin.position, transform.rotation);
            timer = 0;
        }
    }
}
