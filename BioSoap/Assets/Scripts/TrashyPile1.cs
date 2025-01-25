using UnityEngine;

public class TrashyPile1 : MonoBehaviour
{
    public float health = 20;
    public float damage = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            health -= damage;
        }
        if (other.gameObject.CompareTag("Bubble"))
        {
            health -= damage * 4;
        }
        if (other.gameObject.CompareTag("Boom"))
        {
            health -= damage * 5;
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
