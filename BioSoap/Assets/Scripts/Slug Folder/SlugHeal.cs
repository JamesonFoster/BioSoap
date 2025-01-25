using UnityEngine;

public class SlugHeal : MonoBehaviour
{
    public float health = 100;
    public GameObject scaler;
    public float damage = 5;
    public float deathTimer = 1;

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
            deathTimer -= (Time.deltaTime);
            scaler.transform.localScale = new Vector3(1, 1, (1 * deathTimer));
            if (deathTimer <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
