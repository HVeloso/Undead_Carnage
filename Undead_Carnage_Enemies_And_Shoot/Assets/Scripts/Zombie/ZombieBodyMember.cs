using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieBodyMember : MonoBehaviour, IHittable
{
    private ZombieHealth zombieHealth;
    private ZombieMovement zombieMovement;

    void Awake()
    {
        zombieHealth = transform.root.GetComponent<ZombieHealth>();
        zombieMovement = transform.root.GetComponent<ZombieMovement>();
    }

    public void Hitted(float damage) {
        zombieHealth.Hitted(damage);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Bullet")) {
            Hitted(other.GetComponent<Bullet>().Damage);
        }

        if (other.CompareTag("MainCamera")) {
            zombieMovement.SetIsNearTrue();
        }
    }
}
