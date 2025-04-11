using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BugOnEntry : MonoBehaviour
{
    public Image bugImage;
    public Text bugName;

    public void Set(BugData data)
    {
        bugImage.sprite = data.bugImage;
        bugName.text = data.bugName;
    }
}
