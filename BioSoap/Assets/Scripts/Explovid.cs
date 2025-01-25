using UnityEngine;

public class Explovid : MonoBehaviour 
{
    public GameObject _replacement;
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
        }
        if (other.gameObject.CompareTag("Boom"))
        {
            Destroy(gameObject);
            Instantiate(_replacement, transform.position, transform.rotation);
        }
    }
}