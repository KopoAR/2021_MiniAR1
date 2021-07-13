using UnityEngine;

public class SimpleSentencesSender : MonoBehaviour
{
    public ActiveDialogSO ActiveDialogSO;
    public SentencesSO SentencesSO;

    public void Send()
    {
        ActiveDialogSO?.Active(SentencesSO);
    }
}
