using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName ="new active manual", menuName ="Game/ManualActionSO")]
public class ManualActionSO : ScriptableObject
{
//    public UnityAction<ManualSO, Vector3> activeAtion;
    public UnityAction<ManualSO> activeAtion;
    public UnityAction closeAction;

    public void Active(ManualSO data)//, Vector3 pos)
    {
        if (activeAtion != null)
            activeAtion(data); //, pos);
    }

    public void CloseActive()
    {
        if (closeAction != null)
            closeAction();
    }
}
