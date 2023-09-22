using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class GhostFollow : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        //agent.nextPosition = 
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.position;
    }

    //RANDOM POSITION: Must appear in a random waypoint
    //Vector3 RandomPosition()
    //{
    //    Vector3 pos = UnityEngine.Random.RandomRange
    //    return pos;
    //}
}
