using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public struct SentenceData
{
    [TextArea(3, 5)]
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