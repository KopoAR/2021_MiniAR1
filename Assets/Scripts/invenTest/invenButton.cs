using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invenButton : MonoBehaviour
{
    public GameObject invenUI;
    private bool active;

    private void Start()
    {
        active = false;
        invenUI.SetActive(active);
    }
    public void Click()
    {
        active = !active;
        invenUI.SetActive(active);
    }
}
