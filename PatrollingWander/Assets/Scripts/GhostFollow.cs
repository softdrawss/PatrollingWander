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

}
