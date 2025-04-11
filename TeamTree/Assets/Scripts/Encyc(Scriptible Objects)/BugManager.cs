
using System.Collections.Generic;
using UnityEngine;

public class BugManager : MonoBehaviour
{
    public static BugManager instance;

    public List<BugData> allBugs;
    public List<BugData> discoverdBugs = new List<BugData>();

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    public void discoverBug(BugData newBug)
    {
        if (!discoverdBugs.Contains(newBug))
        {
            discoverdBugs.Add(newBug);
            UIManager.Instance.ShowBugPopup(newBug);
        }
    }
}
