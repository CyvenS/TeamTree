using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantableSpot : MonoBehaviour
{
    public PlantTree PlantTree;
    public GameObject Sapling;
    public static bool isSaplingPlanted;
    public static bool isSaplingWatered;
    bool inPlantableSpot;
    // Start is called before the first frame update
    void Start()
    {
        PlantTree = FindObjectOfType<PlantTree>();
        Sapling.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isSaplingWatered)
        {
            Sapling.gameObject.SetActive(true);
            isSaplingPlanted = false;
            isSaplingWatered = false;
            gameObject.SetActive(false);
        }
        if (inPlantableSpot && Input.GetKeyDown(KeyCode.Space)) 
        {
            isSaplingPlanted = true;
            PlantTree.isHoldingSapling = false;
            Debug.Log("Planted Sapling");
        }
        if (inPlantableSpot && isSaplingPlanted && Input.GetKeyDown(KeyCode.Space))
        {
            isSaplingWatered = true;
            Debug.Log("Watered Sapling");
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == PlantTree.gameObject)
        {
            inPlantableSpot = true;
            Debug.Log("In Plantable Spot");
        }

    }
}
