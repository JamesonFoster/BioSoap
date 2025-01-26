using UnityEngine;

public class Explovid : MonoBehaviour 
{
    public GameObject _replacement;
    public GameObject itemdrop;
    bool dropped = false;
    bool splod = false;
    AudioManager am;

    private void Start()
    {
        am = FindObjectOfType<AudioManager>();
        if (am == null) Debug.LogError("_audioManager is NULL");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            am.BovidPlay();
            if (splod == false)
            {
            Destroy(gameObject);
            Instantiate(_replacement, transform.position, transform.rotation);
            splod = true;
            }
        }
        if (other.gameObject.CompareTag("Bubble"))
        {
            am.BovidPlay();
            Destroy(gameObject);
            Instantiate(_replacement, transform.position, transform.rotation);
            if (Random.Range(0,100) > 75)
            {
                if (dropped == false)
                {
                    Instantiate(itemdrop, transform.position, transform.rotation);
                    dropped = true;
                }
            }
        }
        if (other.gameObject.CompareTag("Boom"))
        {
            am.BovidPlay();
            Destroy(gameObject);
            Instantiate(_replacement, transform.position, transform.rotation);
        }
    }
}