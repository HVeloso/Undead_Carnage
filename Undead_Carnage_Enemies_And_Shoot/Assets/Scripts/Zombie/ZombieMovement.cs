using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieMovement : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator animator;
    
    void Awake()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start() {
        agent.SetDestination(Camera.main.transform.position);
    }

    public void SetIsNearTrue() {
        agent.Stop();
        animator.SetTrigger("Is Near");
    }
}
