using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantTree : MonoBehaviour
{
    public GameObject saplingStorage;
    public static bool isHoldingSapling;
    bool inStorage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && inStorage) 
        {
            isHoldingSapling = true;
            Debug.Log("Space");
            inStorage = false;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == saplingStorage.gameObject)
        {
            Debug.Log("Sapling Storage");
            inStorage = true;
        }
    }
}
