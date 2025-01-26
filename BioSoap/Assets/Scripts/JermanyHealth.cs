using UnityEngine;

public class JermanyHealth : MonoBehaviour
{
    public float health = 15;
    public float damage = 5;
    public GameObject itemdrop;
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
            Destroy(gameObject); 
            if (Random.Range(0,100) > 95)
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