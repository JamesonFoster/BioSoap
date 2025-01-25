using UnityEngine;

public class MedPack : MonoBehaviour
{
    public  PlayerHealthSystem;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Medi"))
        {
            Destroy(other);
            if (timr > .5)
                {
                    playerhealth + 20;
                }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
