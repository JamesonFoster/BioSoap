using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour

{
    private float winCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Trash");
        float trashy = enemies.Length;
        if (trashy <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadSceneAsync(3);
        }

    }
}
