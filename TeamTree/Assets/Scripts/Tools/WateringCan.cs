using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WateringCan : MonoBehaviour
{
    public int canLevel;
    public GameObject WaterSpray;
    private GameObject Player;
    private 
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            WateringRun();
        }
    }

    void WateringRun()
    {
        GameObject newSpray = Instantiate(WaterSpray);
        if (canLevel == 0)
        {
            newSpray.transform.localScale = new Vector3(2, 2, 1);
            newSpray.transform.position = (Player.transform.up * 3);
        }
        else if (canLevel == 1)
        {
            newSpray.transform.localScale = new Vector3 (4, 4, 1);
            newSpray.transform.position = (Player.transform.up * 6);
        }
        
    }
}
