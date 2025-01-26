using UnityEngine;

public class Explovid : MonoBehaviour 
{
    public GameObject _replacement;
    public GameObject itemdrop;
    bool dropped = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Instantiate(_replacement, transform.position, transform.rotation);
        }
        if (other.gameObject.CompareTag("Bubble"))
        {
            Destroy(gameObject);
            Instantiate(_replacement, transform.position, transform.rotation);
            if (Random.Range(0,100) > 0)
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
            Destroy(gameObject);
            Instantiate(_replacement, transform.position, transform.rotation);
        }
    }
}