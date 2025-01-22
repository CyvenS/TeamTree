using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private SpriteRenderer spritePlayer;
    public GameObject playerObj;
    public SpriteRenderer[] heldRender;
    // Start is called before the first frame update
    void Start()
    {
        spritePlayer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerObj.transform.position;
        if (playerObj.transform.eulerAngles.z < 180 && playerObj.transform.eulerAngles.z > 0)
        {
            spritePlayer.flipX = false;

            for (int i = 0; i < 3; i++)//flip the sprites of every object the player holds
            {
                heldRender[i].flipX = false;
            }
        }
        if (playerObj.transform.eulerAngles.z > 180 && playerObj.transform.eulerAngles.z < 360)
        {
            spritePlayer.flipX = true;

            for (int i = 0; i < 3; i++)//flip the sprites of every object the player holds
            {
                heldRender[i].flipX = true;
            }
        }
    }
}
