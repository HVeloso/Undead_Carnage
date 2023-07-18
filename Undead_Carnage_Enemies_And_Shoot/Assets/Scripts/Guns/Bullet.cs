using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private PlayerInventory playerInventory;
    public float Damage { get; private set; }

    private void Awake() {
        playerInventory = Camera.main.GetComponent<PlayerInventory>();
        Damage = playerInventory.CurrentGunScript.GetGunStatus().damage;
    }

    private void OnTriggerEnter(Collider other) {
        StartCoroutine(DestroyBullet());
    }

    private IEnumerator DestroyBullet() {
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }
}
