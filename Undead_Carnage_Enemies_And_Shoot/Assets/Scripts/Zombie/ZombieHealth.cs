using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieHealth : MonoBehaviour, IHittable
{
    [SerializeField] private float health = 100f;
    private NavMeshAgent agent;
    private Animator animator;
    private bool isDead = false;

    private void Awake() {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    public void Hitted(float damage) {
        SubtractHealth(damage);
    }

    public void Die() {
        Destroy(gameObject);
    }

    private void SubtractHealth(float damage) {
        health -= damage;
        if (health <= 0 && !isDead) {
            agent.Stop();
            isDead = true;
            animator.SetTrigger("Dead");
        }
    }
}
