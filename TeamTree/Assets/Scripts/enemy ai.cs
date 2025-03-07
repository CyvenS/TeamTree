using System.Collections;
using UnityEngine;
using UnityEngine.AI; 

public class enemyai : MonoBehaviour
{
    public float speed = 2f;
    public float bugHealth;
    private Transform target;
    private NavMeshAgent agent; //seting a new new navmesh
    private bool isDestroyed = false;

    private DestroySelf dcHealth;

    void Start()
    {
        bugHealth = 3f;
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
            bugHealth--;
            Debug.Log(gameObject.name + " hit, Health: " + bugHealth);

            if (bugHealth <= 0)
            {
                isDestroyed = true;
                Destroy(this.gameObject);
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("target")&& !isDestroyed)
        {
            //bugHealth--;
            //if (bugHealth <= 0)
           // {
                //isDestroyed = true;
                //Destroy(gameObject);
            //}
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
}

