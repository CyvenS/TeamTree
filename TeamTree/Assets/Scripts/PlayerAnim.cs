using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private SpriteRenderer spritePlayer;
    public GameObject playerObj;
    [SerializeField] private Animator animator;
    public PlayerMove move;
    // Start is called before the first frame update
    void Start()
    {
        spritePlayer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (move.playerDirection == 500)
        {
            animator.SetBool("isRunning", false);
        }
        else
        {
            animator.SetBool("isRunning", true);
        }
        transform.position = playerObj.transform.position;
        if (playerObj.transform.eulerAngles.z < 180 && playerObj.transform.eulerAngles.z > 0)
        {
            spritePlayer.flipX = false;
        }
        else if (playerObj.transform.eulerAngles.z > 180 && playerObj.transform.eulerAngles.z < 360)
        {
            spritePlayer.flipX = true;
        }
    }
}
