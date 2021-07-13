using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Dialog : MonoBehaviour
{
    [SerializeField] private ActiveDialogSO _onActiveCh;

    [Header("Display Elems")]
    [SerializeField] private GameObject _panel;
    [SerializeField] private TextMeshProUGUI _title;
    [SerializeField] private TextMeshProUGUI _sentence;

    private Queue<string> _sentenceQueue;

    private void Awake()
    {
        Debug.Assert(_onActiveCh != null);
        Debug.Assert(_panel != null);
        Debug.Assert(_title != null);
        Debug.Assert(_sentence != null);

        _panel.SetActive(false);
        _onActiveCh.OnActive += OnActive;
        _sentenceQueue = new Queue<string>();
    }

    private void OnActive(SentencesSO data)
    {
        _sentenceQueue.Clear();

        _title.text = data.Data.Title;                
        foreach(var s in data.Data.Sentences)
        {
            _sentenceQueue.Enqueue(s);
        }

        _panel.SetActive(true);
        NextSentences();
    }

    public void NextSentences()
    {
        if(_sentenceQueue.Count == 0)
        {
            _panel.SetActive(false);
            return;
        }

        var nextSentence = _sentenceQueue.Dequeue();
        _sentence.text = nextSentence;
    }
}
