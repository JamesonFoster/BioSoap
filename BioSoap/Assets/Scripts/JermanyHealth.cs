using UnityEngine;

public class JermanyHealth : MonoBehaviour
{
    public float health = 15;
    public float damage = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bubble"))
        {
            health -= damage;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);  
        }
    }
}