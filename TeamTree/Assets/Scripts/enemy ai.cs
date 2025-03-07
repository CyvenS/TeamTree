using System.Collections;
using UnityEngine;
using UnityEngine.AI; 

public class enemyai : MonoBehaviour
{
    public float speed = 5f; 
    private Transform target;
    private NavMeshAgent agent; //seting a new new navmesh

    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); //grabbing the mesh of the the sttached enemy
        PickNewTarget();
    }

    void Update()
    {
        if (target == null) return;

        if (agent != null)
        {
            
            agent.SetDestination(target.position);
        }
        else
        {
            
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

        
        if (Vector3.Distance(transform.position, target.position) < 0.5f)
        {
            PickNewTarget();
        }
    }

    void PickNewTarget()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("target");
        if (targets.Length > 0)
        {
            target = targets[Random.Range(0, targets.Length)].transform;
        }
    }
}

