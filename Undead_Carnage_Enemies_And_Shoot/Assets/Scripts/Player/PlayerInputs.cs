using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    public delegate void MouseLeftButtonHandler();
    public delegate void MouseRightButtonHandler();

    public event MouseLeftButtonHandler MouseLeftButtonPressed;
    public event MouseRightButtonHandler MouseRightButtonPressed;

    void Update()
    {
        if (Input.GetMouseButton(0)) {
            MouseLeftButtonPressed?.Invoke();
        }

        if (Input.GetMouseButtonDown(1)) {
            MouseRightButtonPressed?.Invoke();
        }
    }
}
