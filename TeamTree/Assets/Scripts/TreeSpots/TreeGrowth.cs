using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script to allow trees to grow and produce resources over time
public class TreeGrowth : MonoBehaviour
{
    //timer for tree growth
    float growthTime;

    //check what stage of growth we're at
    bool growthCheck1;
    bool growthCheck2;

    //Growth Sprites
    public Sprite Sapling1;

    //Grown Tree Object
    public GameObject tree;

    // Start is called before the first frame update
    void Start()
    {
        tree.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //as timer increases tree grows
        growthTime += Time.deltaTime;
        if (growthTime >= 5 && growthTime < 10)
        {
            growthCheck1 = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = Sapling1;
        }
        if (growthTime >= 5 && growthTime < 10)
        {
            growthCheck2 = true;
        }
        //once fully grown enable the tree and disable this object
        if (growthCheck1 && growthCheck2) 
        { 
            tree.gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
