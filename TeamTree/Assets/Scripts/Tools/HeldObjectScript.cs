using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeldObjectScript : MonoBehaviour
{
    public GameObject playerObj;
    public GameObject[] heldObj;
    public SpriteRenderer[] heldRender;
    public int currentHeld;
    public int totalObjCount = 5; // update this variable whenever a new item is added (during development NOT during gameplay)

    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < totalObjCount; i++)
        {
            Debug.Log("passed" + i);
            heldRender[i] = heldObj[i].GetComponent<SpriteRenderer>();
        }
        
}
    // Update is called once per frame
    void Update()
    {

        if (playerObj.transform.eulerAngles.z < 180 && playerObj.transform.eulerAngles.z > 0)
        {
            for (int i = 0; i < totalObjCount; i++) 
            {
                Debug.Log("passed" + i);
                heldRender[i].flipX = false;
            }
        }
        else if (playerObj.transform.eulerAngles.z > 180 && playerObj.transform.eulerAngles.z < 360)
        {
            for (int i = 0; i < totalObjCount; i++) 
            {
                heldRender[i].flipX = true;
            }
        }


        if (Input.GetKey(KeyCode.Alpha1))
        {
            for (int i = 0; i < totalObjCount; i++) //turn each heldObj off
            {
                heldObj[i].SetActive(false);
            }
            heldObj[1].SetActive(true); //turn current item on
            currentHeld = 1;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            for (int i = 0; i < totalObjCount; i++)
            {
                heldObj[i].SetActive(false); 
            }
            heldObj[2].SetActive(true);
            currentHeld = 2;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            for (int i = 0; i < totalObjCount; i++)
            {
                heldObj[i].SetActive(false);
            }
            heldObj[3].SetActive(true);
            currentHeld = 3;
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            for (int i = 0; i < totalObjCount; i++)
            {
                heldObj[i].SetActive(false);
            }
            heldObj[4].SetActive(true);
            currentHeld = 4;
        }
    }

    public int ObjectCount(int objCount)
    {
        objCount = totalObjCount;
        return objCount;
    }


}
