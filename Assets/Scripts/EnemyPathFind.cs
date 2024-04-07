using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyPathFind : MonoBehaviour
{
    NavMeshAgent Agent;
    [SerializeField] private float AgentSpeed;
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        Agent.speed = AgentSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<AIConeOfVision>().CanSeePlayer)
        {
            Agent.SetDestination(GameObject.FindGameObjectWithTag("Player").transform.position);
        }
    }
}
