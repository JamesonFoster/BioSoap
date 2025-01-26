using UnityEngine;

public class SlugHeal : MonoBehaviour
{
    [SerializeField]
    public float health = 100;
    public GameObject scaler;
    public GameObject itemdrop;
    public float damage = 5;
    public float deathTimer = 1;
    public bool dropped = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bubble"))
        {
            health -= damage;
        }
        if (other.gameObject.CompareTag("Boom"))
        {
            health -= damage * 10;
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
                if (Random.Range(0,100) > 65)
            {
                if (dropped == false)
                {
                    Instantiate(itemdrop, transform.position, transform.rotation);
                    dropped = true;
                }
            }
            }
    }
    }
}