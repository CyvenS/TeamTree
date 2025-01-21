using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int playerSpeed = 5;
    public float playerDirection;
    private Rigidbody2D rigBodPlayer;
    // Start is called before the first frame update
    void Start()
    {
        rigBodPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.eulerAngles = new Vector3(0,0,InputPick(playerDirection));

        if (InputPick(playerDirection) != 500)
        {
            rigBodPlayer.velocity = gameObject.transform.up * playerSpeed;
        }
        else
        {
            rigBodPlayer.velocity = new Vector2(0,0);
        }

        playerDirection = InputPick(playerDirection);
    }

    private float InputPick(float direction)
    {
        bool keyUp;
        bool keyLeft;
        bool keyDown;
        bool keyRight;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            keyUp = true;
        }
        else
        {
            keyUp = false;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            keyLeft = true;
        }
        else
        {
            keyLeft = false;
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            keyDown = true;
        }
        else
        {
            keyDown = false;
        }

        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            keyRight = true;
        }
        else
        {
            keyRight = false;
        }

        if (keyUp && keyDown)
        {
            keyUp = false;
            keyDown = false;
        }
        if (keyLeft && keyRight)
        {
            keyLeft = false;
            keyRight = false;
        }

        if (keyUp)
        {
            if (keyLeft)
            {
                direction = 315;
            }
            else if (keyRight)
            {
                direction = 45;
            }
            else if (!keyLeft &&  !keyRight)
            {
                direction = 0;
            }
        }
        else if(keyDown)
        {
            if (keyLeft)
            {
                direction = 225;
            }
            else if (keyRight)
            {
                direction = 135;
            }
            else if (!keyLeft && !keyRight)
            {
                direction = 180;
            }
        }
        else if (keyLeft)
        {
            direction = 270;
        }
        else if (keyRight)
        { 
            direction = 90; 
        }
        else
        {
            direction = 500;
        }

        return direction;
    }

}
