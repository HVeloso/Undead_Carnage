using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField] private GameObject[] guns = new GameObject[2];
    private GameObject currentGun;
    public Gun CurrentGunScript { get; private set; }

    private void Awake() {
        guns[0].SetActive(true);
        guns[1].SetActive(false);

        currentGun = guns[0];
        CurrentGunScript = currentGun.GetComponent<Gun>();
    }

    private void SwitchCurrentGun() {
        currentGun.SetActive(false);
        currentGun = currentGun == guns[0] ? guns[1] : guns[0];
        CurrentGunScript = currentGun.GetComponent<Gun>();
        currentGun.SetActive(true);
    }

    public void OnMouseRightButtonPressed() {
        SwitchCurrentGun();
    }
}
