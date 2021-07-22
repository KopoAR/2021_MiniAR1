using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new cold launch so", menuName = "Game/ColdLaunchSO")]
public class ColdLaunchSO : ScriptableObject
{
    public bool isColdLaunch = true;

    public void Set(bool b)
    {
        isColdLaunch = b;
    }
}
