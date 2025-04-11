
using UnityEngine;

[CreateAssetMenu (fileName = "newBug", menuName = "Encyclopedia/Bug")] // creates a sub directory to house all data for the encyclopedia
public class BugData : ScriptableObject
{
    public string bugName;
    [TextArea] public string info;
    public Sprite bugImage;
    // dont add anything to the bug sub menu unless it is a valid bug
}
