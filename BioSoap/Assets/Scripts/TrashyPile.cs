using UnityEngine;

public class TrashyPile : MonoBehaviour
{
    public float health = 100;
    public GameObject scaler;
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
        scaler.transform.localScale = new Vector3((health / 100), (health / 100), (health / 100));
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
