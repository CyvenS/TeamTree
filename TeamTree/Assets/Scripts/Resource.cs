using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour
{
    public ResourceManager ResourceManager;
    private void Awake()
    {
        //find the resource manager object
        ResourceManager = FindAnyObjectByType<ResourceManager>();
    }

    //increase the playre's resource amount each time they collide with the resource object
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            ResourceManager.resourceAmount++;
        }
    }
}
