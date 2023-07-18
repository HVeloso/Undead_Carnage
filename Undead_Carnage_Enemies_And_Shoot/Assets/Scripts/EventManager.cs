using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    private ShootSystem shootSystem;
    private PlayerInputs playerInputs;
    private PlayerInventory playerInventory;

    void Awake()
    {
        shootSystem = Camera.main.GetComponent<ShootSystem>();
        playerInputs = Camera.main.GetComponent<PlayerInputs>();
        playerInventory = Camera.main.GetComponent<PlayerInventory>();
    }

    void Start()
    {
        playerInputs.MouseLeftButtonPressed += shootSystem.OnMouseLeftButtonPressed;

        playerInputs.MouseRightButtonPressed += playerInventory.OnMouseRightButtonPressed;
    }
}
