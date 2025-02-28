using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeHP : MonoBehaviour
{
    //Jacob Grypma
    //Tree HP decreases when in contact with enemy
    //Upon Tree reaching zero HP Tree gameobject is destroyed
    
    public int treeHP; //int to store HP

    // Update is called once per frame
    void Update()
    {
        //destroy gameobject when HP reaches zero
        if (treeHP <= 0)
        {
            GameObject.Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //whenever gameobject tagged as an enemy collides with tree, subtract hp
        if (collision.gameObject.tag == "enemy")
        {
            treeHP--;
        }
    }
}
