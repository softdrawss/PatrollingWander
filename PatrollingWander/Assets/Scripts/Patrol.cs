using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform target;
    public GameObject[] waypoints;

    int patrolWP = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Random position

    }

    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f) Patrolling();
    }

    void Patrolling()
    {
        patrolWP = (patrolWP + 1) % waypoints.Length;
        Seek(waypoints[patrolWP].transform.position);
    }

    void Seek(Vector3 pos)
    {
        if (waypoints.Length == 0)
            return;

        // Set the agent to go to the currently selected destination.
        agent.destination = waypoints[patrolWP].transform.position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        patrolWP = (patrolWP + 1) % waypoints.Length;
    }

}
