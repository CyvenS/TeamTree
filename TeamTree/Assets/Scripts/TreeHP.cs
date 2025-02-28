using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeHP : MonoBehaviour
{
    //Jacob Grypma
    //Tree HP decreases when in contact with enemy
    //Upon Tree reaching zero HP Tree gameobject is destroyed
    //This is called TreeHP but it can honestly be put on any gameobject as long as you use the right tag
    
    public int treeHP; //int to store HP
    public string enemyTag; //set to whatever tag the enemy is

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
        if (collision.gameObject.tag == enemyTag)
        {
            treeHP--;
        }
    }
}
