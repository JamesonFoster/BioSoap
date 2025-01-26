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
            if (deathTimer >= 1)
            {
                am.PlayHate();
            }
            deathTimer -= (Time.deltaTime);
            scaler.transform.localScale = new Vector3(1, 1, (1 * deathTimer));
            if (deathTimer <= 0)
            {
                Destroy(gameObject);
                if (Random.Range(0,100) > 25)
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