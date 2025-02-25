using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class TreeSpot : MonoBehaviour
{
    public AudioSource TreePlant;
    public GameObject Player;
    public GameObject HeldObj;
    public HeldObjectScript HeldObjectScript;
    public float playerDis;
    public bool inRange;
    private SpriteRenderer treespotSprite;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("PlayerObj");
        HeldObj = GameObject.Find("HeldObj");
        treespotSprite = GetComponent<SpriteRenderer>();
        HeldObjectScript = HeldObj.GetComponent<HeldObjectScript>();
        TreePlant = GetComponent<AudioSource>();

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
            if (HeldObjectScript.currentHeld == 2) //if holding sapling, plant tree (colour red)
            {
                treespotSprite.color = Color.red;
                TreePlant.Play ();
                
            }
            else if (HeldObjectScript.currentHeld == 1 && treespotSprite.color == Color.red) // if holding watering can and tree is planted, water tree (colour magenta)
            {
                treespotSprite.color = Color.magenta;
            }
        }
    }
}
