using UnityEngine;

public class SimpleSentencesSender : MonoBehaviour
{
    public ActiveDialogSO ActiveDialogSO;
    public SentencesSO SentencesSO;
    
    [SerializeField] private SentencesData _sentencesData;

    public void Send()
    {
        ActiveDialogSO?.Active(SentencesSO);
    }

    public void SendLocal()
    {
        var so = ScriptableObject.CreateInstance<SentencesSO>();
        so.Data = _sentencesData;

        ActiveDialogSO?.Active(so);
    }
}
    