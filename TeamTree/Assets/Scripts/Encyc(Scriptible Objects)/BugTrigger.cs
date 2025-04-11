using UnityEngine;

public class BugTrigger : MonoBehaviour
{
    public BugData bugInfo;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            BugManager.instance.discoverBug(bugInfo);
            Destroy(gameObject); // only discover once
        }
    }
}

