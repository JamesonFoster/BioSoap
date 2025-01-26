using UnityEngine;

public class BubbleBomb : MonoBehaviour
{
    float timer = 0;
    public float timtoexplo = 3;
    public GameObject _replacement;
    AudioManager am;

    private void Start()
    {
        am = FindObjectOfType<AudioManager>();
        if (am == null) Debug.LogError("_audioManager is NULL");
    }

    // Update is called once per frame
    void Update()
    {
        timer += (Time.deltaTime);
        if (timer >= timtoexplo)
        {
            am.BBomb();
            Destroy(gameObject);
            Instantiate(_replacement, transform.position, transform.rotation);
        }
    }
}
