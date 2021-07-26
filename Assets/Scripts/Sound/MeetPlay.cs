using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeetPlay : MonoBehaviour
{
    private BGMManager bgmManager;
    public int bgmNum;
    public int winBG;
    public int loseBG;


    void Start()
    {
        StartCoroutine(TryPlayBGM());
    }

    private IEnumerator TryPlayBGM()
    {
        while (BGMManager.instance == null)
        {
            yield return new WaitForFixedUpdate();
        }

        bgmManager = BGMManager.instance;
        PlayBGM(bgmNum);
    }

    public void PlayBGM(int n)
    {
        bgmManager.Play(n);
        bgmManager.SetVoulme(0.2f, n);
    }

    
    public void WinBGM(int winBG)
    {
        bgmManager.Stop(bgmNum);
        bgmManager.Play(winBG);
    }

    public void LoseBGM(int loseBG)
    {
        bgmManager.Stop(bgmNum);
        bgmManager.Play(loseBG);
    }
}

