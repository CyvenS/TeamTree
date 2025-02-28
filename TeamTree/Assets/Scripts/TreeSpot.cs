using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class TreeSpot : MonoBehaviour
{
    public AudioSource TreePlant;
    public int occupied; // 0 is empty, 1 is sapling, 2 is invasive plant
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


        if (inRange && Input.GetKey(KeyCode.E)) //keep this for sapling planting + shovel
        {
            if (occupied == 0 && HeldObjectScript.currentHeld == 2) //if holding sapling, plant tree (colour red for now, update to spawn sapling gameobject)
            {
                treespotSprite.color = Color.red;
                occupied = 1;
                TreePlant.Play();
            }
            else if (occupied == 2 && HeldObjectScript.currentHeld == 3) //if holding shovel, remove invasive plant. (colour white for now, update to kill invasive plant gameobject)
            {
                occupied = 0;
                treespotSprite.color = Color.white;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Water") && occupied == 1)
        {
            treespotSprite.color = Color.magenta;
            isWatered = true;
        }
    }
}
