using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class XRRigManager : MonoBehaviour
{
    [SerializeField] private GameObject _rigSimulator;

    private void Awake()
    {
        Debug.Assert(_rigSimulator != null);

        if(XRSettings.loadedDeviceName != "MockHMD Display")
        {
            Debug.Log("Disable rig simulator");
            _rigSimulator.SetActive(false);
        }
    }
}
