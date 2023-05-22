using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class AIMove : MonoBehaviour
{

    private NavMeshAgent agent;
    public Transform[] waypoints;
    int wayPointIndex;
    Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        updateDestination();
    }

    // Update is called once per frame
    void Update()
    {
       if (Vector3.Distance(transform.position, target) < 1)
        {
            iterateIndex();
            updateDestination();
            Debug.Log("Changing waypoint");
        }
    }



    void updateDestination()
    {
        target = waypoints[wayPointIndex].position;
        agent.SetDestination(target);
    }
    void iterateIndex()
    {
        wayPointIndex++;
        if (wayPointIndex >= waypoints.Length)
        {
            wayPointIndex = 0;
        }
    }
}
