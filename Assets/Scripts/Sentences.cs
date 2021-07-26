using UnityEngine.Events;

[System.Serializable]
public struct SentenceData
{
    public string Sentence;
    public UnityEvent BeginActions;
    public UnityEvent Actions;
    public UnityEvent EndActions;
}

[System.Serializable]
public struct SentencesData
{
    public string Title;
    public SentenceData[] Sentences;
}