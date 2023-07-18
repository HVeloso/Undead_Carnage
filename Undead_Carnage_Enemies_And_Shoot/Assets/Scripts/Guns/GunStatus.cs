using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GunStatus", menuName = "ScriptableObjects/GunStatus")]
public class GunStatus : ScriptableObject
{
    public new string name;
    public float damage;
    public float fireRate;
    public int ammo;
}
