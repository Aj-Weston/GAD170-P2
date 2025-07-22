using UnityEngine;

public class HunterSpawner : MonoBehaviour
{
    public GameObject hunterPrefab;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(hunterPrefab, new Vector3(-8, -3.8f, 1), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        /* Turning Hunter On/Off
        if (Input.GetKeyDown(KeyCode.Space) && hunter.activeSelf == true)
        {
            hunter.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && hunter.activeSelf == false)
        {
            hunter.SetActive(true);
        }
        */
    }
}
