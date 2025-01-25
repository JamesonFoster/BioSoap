using UnityEngine;

public class WeaponSwaper : MonoBehaviour
{
    public GameObject projectilePrefabBomb;
    public GameObject projectilePrefabShot;
    public GameObject projectilePrefabTheBub;

    [SerializeField]
    public float buttonDelayB = 7;
    float lastButtonTime = 0;
    public float buttonDelayT = 0.05f;
    public float buttonDelayS = 1;
    public int weaponselect = 1;
    public float bombCount = 1;
    private float timr = 0;

    [SerializeField]
    private Transform origin;

    void Start()
    {

    }
    //Detects Item Grabs
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BDrop"))
        {
            Destroy(other);
            if (timr > .5)
                {
                bombCount += 1;
                timr = 0;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        lastButtonTime += (Time.deltaTime);
        timr += (Time.deltaTime);
        //Weapson Swaps
        if (Input.GetKey("1"))
        {
            weaponselect = 1;
        }
        if (Input.GetKey("2"))
        {
            weaponselect = 2;
        }
        if (Input.GetKey("3"))
        {
            weaponselect = 3;
        }
        //Weapson Actions
        if (weaponselect <= 1)
        {
            if (lastButtonTime >= buttonDelayS)
            {
                if (Input.GetButton("Fire1"))
                {
                    Instantiate(projectilePrefabShot, origin.position, transform.rotation);
                    Debug.Log("FireBubble");
                    lastButtonTime = 0;
                }
            }
        }
        if (weaponselect <= 2 && weaponselect > 1)
        {
            if (lastButtonTime >= buttonDelayT)
            {
                if (Input.GetButton("Fire1"))
                {
                    Instantiate(projectilePrefabTheBub, origin.position, transform.rotation);
                    Debug.Log("FireBubble");
                    lastButtonTime = 0;
                }
            }
        }
        else
            {
            if (bombCount > 0)
            {
                if (lastButtonTime >= buttonDelayB)
                {
                    if (Input.GetButton("Fire1"))
                    {
                        Instantiate(projectilePrefabBomb, origin.position, transform.rotation);
                        Debug.Log("FireBubble");
                        lastButtonTime = 0;
                    }
                }
            }
        }
    }
}