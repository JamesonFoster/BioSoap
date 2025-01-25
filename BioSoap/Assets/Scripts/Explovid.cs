using UnityEngine;

public class Explovid : MonoBehaviour 
{
    public GameObject _replacement;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(_replacement, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Bubble"))
        {
            Instantiate(_replacement, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}