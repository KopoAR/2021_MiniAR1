using UnityEngine.Events;

[System.Serializable]
public struct SentenceData
{
    public string Sentence;
    public UnityEvent Actions;
}

[System.Serializable]
public struct SentencesData
{
    public string Title;
    public SentenceData[] Sentences;
}