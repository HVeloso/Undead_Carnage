using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSystem : MonoBehaviour
{
    [SerializeField] private float shootRange = 30f;
    [SerializeField] private GameObject bullet;
    private PlayerInventory playerInventory;
    private bool shootCooldown = false;

    private void Awake() {
        playerInventory = Camera.main.GetComponent<PlayerInventory>();
    }

    private void Shoot() {
        if(!shootCooldown) {
            StartCoroutine(WaitShootCooldown());
            Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit, shootRange);

            if (hit.collider != null && hit.collider.GetComponent<IHittable>() is IHittable) {
                Instantiate(bullet, hit.point, Quaternion.identity);
            }
        }
    }

    private IEnumerator WaitShootCooldown() {
        shootCooldown = true;
        yield return new WaitForSeconds(playerInventory.CurrentGunScript.GetGunStatus().fireRate);
        shootCooldown = false;
    }

    public void OnMouseLeftButtonPressed() {
        Shoot();
    }
}
