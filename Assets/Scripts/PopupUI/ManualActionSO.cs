using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName ="new active manual", menuName ="Game/ManualActionSO")]
public class ManualActionSO : ScriptableObject
{
    public UnityAction<ManualSO> activeAtion;
    public UnityAction closeAction;

    public void Active(ManualSO data)
    {
        if (activeAtion != null)
            activeAtion(data);
    }

    public void CloseActive()
    {
        if (closeAction != null)
            closeAction();
    }
}
