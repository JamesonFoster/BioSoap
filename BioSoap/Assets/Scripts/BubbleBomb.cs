using UnityEngine;

public class BubbleBomb : MonoBehaviour
{
    float timer = 0;
    public float timtoexplo = 3;
    public GameObject _replacement;

    // Update is called once per frame
    void Update()
    {
        timer += (Time.deltaTime);
        if (timer >= timtoexplo)
        {
            Destroy(gameObject);
            Instantiate(_replacement, transform.position, transform.rotation);
        }
    }
}
