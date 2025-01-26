using UnityEngine;

public class JermanyHealth : MonoBehaviour
{
    public float health = 15;
    public float damage = 5;
    public GameObject itemdrop;
    public GameObject scaler;
    public float deathTimer = 1;
    public bool dropped = false;
    AudioManager am;

    private void Start()
    {
        am = FindObjectOfType<AudioManager>();
        if (am == null) Debug.LogError("_audioManager is NULL");
    }

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
            scaler.transform.localScale = new Vector3((1 * deathTimer),(1 * deathTimer), 1);
            if (deathTimer <= 0)
            {
                Destroy(gameObject);
            Destroy(gameObject);
                am.Poofy();
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
}