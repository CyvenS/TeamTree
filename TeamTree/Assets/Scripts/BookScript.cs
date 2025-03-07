using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookScript : MonoBehaviour
{
    public bool isOpen;
    public GameObject Book;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (isOpen == true)
            {
                isOpen = false;
                Book.SetActive(false);
            }
            if (isOpen == false)
            {
                isOpen = true;
                Book.SetActive(true);
            }
        }
    }
}
