using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotateCam : MonoBehaviour
{
    public float RotationSpeed = 3f;
    [SerializeField] private GameObject Cam;

    void Update()
    {
        var rotateAngle = (RotationSpeed * Time.deltaTime);

        if (Keyboard.current.qKey.isPressed)
            Cam.transform.Rotate(0.0f, rotateAngle, 0.0f);

        if (Keyboard.current.eKey.isPressed)
            Cam.transform.Rotate(0.0f, -rotateAngle, 0.0f);
    }
}
