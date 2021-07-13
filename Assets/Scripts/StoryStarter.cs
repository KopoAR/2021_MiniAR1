using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryStarter : MonoBehaviour
{
    [SerializeField] 
    private SimpleSentencesSender _sentencesSender;

    void Start()
    {
        _sentencesSender?.SendLocal();
    }
}
