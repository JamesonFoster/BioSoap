using UnityEngine;

public class CamraFollow : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        player = GameObject.Find("Soapy");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 1, -5);
    }
}
