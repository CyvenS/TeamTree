using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceManager : MonoBehaviour
{
    //store the amount of resources the player has
    public int resourceAmount;
    public int playerScore;

    public TextMeshProUGUI ScoreDisp;
    public TextMeshProUGUI ResourceDisp;


    void Update()
    {
        ResourceDisp.text = resourceAmount.ToString();
        ScoreDisp.text = playerScore.ToString();
    }

}

