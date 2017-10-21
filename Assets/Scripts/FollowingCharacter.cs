using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowingCharacter : MonoBehaviour
{

    public Transform Player;
    public List<Transform> patrolRoute;
    public bool seenPlayer;
    public float followingSpeed = 1;

    private NavMeshAgent agent;
    private int destPoint;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        seenPlayer = false;
        destPoint = 0;
        if (patrolRoute.Count > 0)
        {
            agent.destination = patrolRoute[0].position;
        }
    }

    void Update()
    {
        if (seenPlayer)
        {
            agent.destination = Player.position;
            agent.speed = followingSpeed;
        }
        else
        {
            if (agent.remainingDistance < 0.5f)
                GoToNextPoint();
        }
    }

    private void GoToNextPoint()
    {
        if (patrolRoute.Count == 0)
        {
            return;
        }
        destPoint = (destPoint + 1) % patrolRoute.Count;
        if (destPoint == 0 || destPoint == patrolRoute.Count - 1)
        {
            agent.autoBraking = true;
        }
        else
        {
            agent.autoBraking = false;
        }
        agent.destination = patrolRoute[destPoint].position;
    }
}
