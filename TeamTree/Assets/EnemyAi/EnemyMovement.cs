using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Transform tree;
    public float moveSpeed;


    void Start()
    {
        tree = FindObjectOfType<TreeSpot>().transform;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, tree.transform.position, moveSpeed * Time.deltaTime);    //Constantly move the enemy towards the player
    }
}