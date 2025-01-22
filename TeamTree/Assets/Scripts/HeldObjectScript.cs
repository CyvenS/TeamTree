using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeldObjectScript : MonoBehaviour
{
    public GameObject[] currentObj;
    public SpriteRenderer[] heldRender;
    public int totalObjCount = 3;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            heldRender[i] = currentObj[i].GetComponent<SpriteRenderer>();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            for (int i = 0; i < 3; i++)
            {
                currentObj[i].SetActive(false);
            }
            currentObj[1].SetActive(true);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            for (int i = 0; i < 3; i++)
            {
                currentObj[i].SetActive(false);
            }
            currentObj[2].SetActive(true);
        }
    }

    public int ObjectCount(int objCount)
    {
        objCount = totalObjCount;
        return objCount;
    }
}
