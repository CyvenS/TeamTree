using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TreeSpot : MonoBehaviour
{
    public GameObject Player;
    public float playerDis;
    public bool inRange;
    private SpriteRenderer treespotSprite;
    // Start is called before the first frame update
    void Start()
    {
        treespotSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       playerDis = Vector3.Distance (Player.transform.position, gameObject.transform.position);
        if (playerDis < 10)
        {
            inRange = true;
        }
        else if (playerDis > 10)
        {
            inRange= false;
        }


        if (inRange && Input.GetKey(KeyCode.E))
        {
            treespotSprite.color = Color.red;
        }
    }
}
