using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pesticide : MonoBehaviour
{
    public int sprayLevel;
    public GameObject PestSpray;
    private GameObject Player;
    private
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        DebugSpray();
        if (Input.GetKeyDown(KeyCode.E))
        {
            PestSprayRun();
        }
    }

    void PestSprayRun()
    {
        GameObject newSpray = Instantiate(PestSpray);
        if (sprayLevel == 0)
        {
            newSpray.transform.localScale = new Vector3(2, 2, 1);
            newSpray.transform.position = Player.transform.position;
            newSpray.transform.position = newSpray.transform.position + (Player.transform.up * 3);
        }
        else if (sprayLevel == 1)
        {
            newSpray.transform.localScale = new Vector3(3, 3, 1);
            newSpray.transform.position = Player.transform.position;
            newSpray.transform.position = newSpray.transform.position + (Player.transform.up * 4);
        }
        else //if (sprayLevel == 2)
        {
            newSpray.transform.localScale = new Vector3(3, 3, 1);
            newSpray.transform.position = Player.transform.position;
            newSpray.transform.position = newSpray.transform.position + (Player.transform.up * 4);

            newSpray = Instantiate(PestSpray);
            newSpray.transform.localScale = new Vector3(2, 2, 1);
            newSpray.transform.position = Player.transform.position;
            newSpray.transform.position = newSpray.transform.position + (Player.transform.up * 3);
            newSpray.transform.position = newSpray.transform.position + (Player.transform.right * 2);
            newSpray = Instantiate(PestSpray);
            newSpray.transform.localScale = new Vector3(2, 2, 1);
            newSpray.transform.position = Player.transform.position;
            newSpray.transform.position = newSpray.transform.position + (Player.transform.up * 3);
            newSpray.transform.position = newSpray.transform.position + (Player.transform.right * -2);

        }
    }
    void DebugSpray()
    {
        sprayLevel++;
    }
}
