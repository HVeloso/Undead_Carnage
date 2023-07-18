using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GunStatus gunStatus;

    public GunStatus GetGunStatus() {
        return gunStatus;
    }
}
