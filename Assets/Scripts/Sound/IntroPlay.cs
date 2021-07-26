using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroPlay : MonoBehaviour
{
    private BGMManager bgmManager;

    void Start()
    {
        StartCoroutine(TryPlayBGM());
    }

    private IEnumerator TryPlayBGM()
    {
        while(BGMManager.instance == null)
        {
            yield return new WaitForFixedUpdate();
        }

        bgmManager = BGMManager.instance;
        PlayBGM();
    }

    public void PlayBGM()
    {
        bgmManager.Play(8);
        bgmManager.SetVoulme(0.2f, 8);
    }
}
