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
        DebugWater();
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
            newSpray.transform.position = Player.transform.position;
            newSpray.transform.position = newSpray.transform.position + (Player.transform.up * 3);
        }
        else if (canLevel == 1)
        {
            newSpray.transform.localScale = new Vector3 (3, 3, 1);
            newSpray.transform.position = Player.transform.position;
            newSpray.transform.position = newSpray.transform.position + (Player.transform.up * 4);
        }
        else //if (canLevel == 2)
        {
            newSpray.transform.localScale = new Vector3(3, 3, 1);
            newSpray.transform.position = Player.transform.position;
            newSpray.transform.position = newSpray.transform.position + (Player.transform.up * 4);

            newSpray = Instantiate(WaterSpray);
            newSpray.transform.localScale = new Vector3(2, 2, 1);
            newSpray.transform.position = Player.transform.position;
            newSpray.transform.position = newSpray.transform.position + (Player.transform.up * 3);
            newSpray.transform.position = newSpray.transform.position + (Player.transform.right * 2);
            newSpray = Instantiate(WaterSpray);
            newSpray.transform.localScale = new Vector3(2, 2, 1);
            newSpray.transform.position = Player.transform.position;
            newSpray.transform.position = newSpray.transform.position + (Player.transform.up * 3);
            newSpray.transform.position = newSpray.transform.position + (Player.transform.right * -2);

        }

    }

    void DebugWater()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            canLevel++;
        }
    }
}
