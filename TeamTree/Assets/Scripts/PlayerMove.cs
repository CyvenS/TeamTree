using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public int playerSpeed = 10;
    public float playerDirection;
    private Rigidbody2D rigBodPlayer;
    private SpriteRenderer spritePlayer;

    public GameObject Resources;

    public int Health;
    public TextMeshProUGUI HealthText;
    // Start is called before the first frame update
    void Start()
    {
        rigBodPlayer = GetComponent<Rigidbody2D>();
        Health = 20;
        HealthText.text = Health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (InputPick(playerDirection) != 500)
        {
            gameObject.transform.eulerAngles = new Vector3(0, 0, InputPick(playerDirection));
            rigBodPlayer.velocity = gameObject.transform.up * playerSpeed;
        }
        else
        {
            rigBodPlayer.velocity = new Vector2(0,0);
        }

        playerDirection = InputPick(playerDirection);
    }

    public float InputPick(float direction)
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
                direction = 45;
            }
            else if (keyRight)
            {
                direction = 315;
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
                direction = 135;
            }
            else if (keyRight)
            {
                direction = 225;
            }
            else if (!keyLeft && !keyRight)
            {
                direction = 180;
            }
        }
        else if (keyLeft)
        {
            direction = 90;
        }
        else if (keyRight)
        { 
            direction = 270; 
        }
        else
        {
            direction = 500;
        }

        return direction;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("touch");
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Health--;
            HealthText.text = Health.ToString();

            if (Health <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
    void DebugWater()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (Resources.GetComponent<ResourceManager>().resourceAmount >= 5)
            {
                Resources.GetComponent<ResourceManager>().resourceAmount = Resources.GetComponent<ResourceManager>().resourceAmount - 5;
                Health = Health + 10;
                if (Health > 20)
                {
                    Health = 20;
                }
            }
        }
    }

}
