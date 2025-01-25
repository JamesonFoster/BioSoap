using UnityEngine;

public class Explotion : MonoBehaviour
{
    public GameObject scaler;
    public float deathTimer = 1;

    // Update is called once per frame
    void Update()
    {
            deathTimer -= (Time.deltaTime);
            scaler.transform.localScale = new Vector3((4 * deathTimer), (4 * deathTimer), (4 * deathTimer));
            if (deathTimer <= 0)
            {
                Destroy(gameObject);
            }
    }
}
