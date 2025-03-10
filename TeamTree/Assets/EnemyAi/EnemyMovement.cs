using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    Transform tree;
    public float moveSpeed;


    void Start()
    {
        tree = FindObjectOfType<trackingManager>().transform;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, tree.transform.position, moveSpeed * Time.deltaTime);    
    }


}