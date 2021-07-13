using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "new active dialog ch", menuName = "Game/ActiveDialogChannel")]
public class ActiveDialogSO : ScriptableObject
{
    public UnityAction<SentencesSO> OnActive;

    public void Active(SentencesSO data)
    {
        if (OnActive != null)
            OnActive(data);
    }
}
