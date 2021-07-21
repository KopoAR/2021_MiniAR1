using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAnchorY : MonoBehaviour
{
    [SerializeField] private Transform _camTr;
    private RectTransform _rectTr;
    private Vector3 _originAngle;

    private void Awake()
    {
        Debug.Assert(_camTr != null);
        _rectTr = GetComponent<RectTransform>();
        _originAngle = _rectTr.rotation.eulerAngles;
    }

    private void LateUpdate()
    {
        var angle = _camTr.rotation.eulerAngles;
        angle.x = _originAngle.x;
        angle.z = _originAngle.z;
        //Debug.Log($"apply angle {angle}");

        _rectTr.rotation = Quaternion.Euler(angle);
        //Debug.Log($"current angle {_rectTr.rotation.eulerAngles}");
    }
}
