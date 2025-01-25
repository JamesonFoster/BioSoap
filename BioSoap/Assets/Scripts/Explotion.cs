using UnityEngine;

public class Explotion : MonoBehaviour
{
    public GameObject scaler;
    public float deathTimer = 1;

    // Update is called once per frame
    void Update()
    {
            deathTimer -= (Time.deltaTime);
            scaler.transform.localScale = new Vector3((2 * deathTimer), (2 * deathTimer), (2 * deathTimer));
            if (deathTimer <= 0)
            {
                Destroy(gameObject);
            }
    }
}
