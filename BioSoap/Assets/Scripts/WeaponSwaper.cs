using UnityEngine;

public class WeaponSwaper : MonoBehaviour
{
    public GameObject projectilePrefabBomb;
    public GameObject projectilePrefabShot;
    public GameObject projectilePrefabTheBub;
    public GameObject BubGun;

    [SerializeField]
    public float buttonDelayB = 7;
    float lastButtonTime = 0;
    public float buttonDelayT = 0.05f;
    public float buttonDelayS = 1;
    public int weaponselect = 1;
    public float bombCount = 1;
    public float BubbleCount = 30;
    private float timr = 0;
    public MeshRenderer ff;
    public MeshRenderer fa;
    public MeshRenderer fb;
    public MeshRenderer fc;
    public MeshRenderer ee;
    public MeshRenderer ea;
    public MeshRenderer eb;
    public MeshRenderer ec;


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
    
        if (other.gameObject.CompareTag("Mag"))
        {
            Destroy(other);
            if (timr > .5)
                {
                BubbleCount += 20;
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
            ff.enabled = false;
            fa.enabled = false;
            fb.enabled = false;
            fc.enabled = false;
            ee.enabled = true;
            ea.enabled = true;
            eb.enabled = true;
            ec.enabled = true;
            
        }
        if (Input.GetKey("2"))
        {
            weaponselect = 2;
            ff.enabled = true;
            fa.enabled = true;
            fb.enabled = true;
            fc.enabled = true;
            ee.enabled = false;
            ea.enabled = false;
            eb.enabled = false;
            ec.enabled = false;
        }
        if (Input.GetKey("3"))
        {
            weaponselect = 3;
            ff.enabled = false;
            fa.enabled = false;
            fb.enabled = false;
            fc.enabled = false;
            ee.enabled = true;
            ea.enabled = true;
            eb.enabled = true;
            ec.enabled = true;
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
            if (BubbleCount > 0)
            {
                if (lastButtonTime >= buttonDelayT)
                {
                    if (Input.GetButton("Fire1"))
                    {
                        Instantiate(projectilePrefabTheBub, origin.position, transform.rotation);
                        Debug.Log("FireBubble");
                        BubbleCount -= 1;
                        lastButtonTime = 0;
                    }
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
                        bombCount -= 1;
                        lastButtonTime = 0;
                    }
                }
            }
        }
    }
}