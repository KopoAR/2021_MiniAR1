using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeetPlay : MonoBehaviour
{
    private BGMManager bgmManager;


    void Start()
    {
        bgmManager = BGMManager.instance;
        bgmManager.Stop(4);
        PlayBGM();

    }

    public void PlayBGM()
    {
        bgmManager.Play(6);
        bgmManager.SetVoulme(0.2f, 6);
    }

    
    public void EndBGM()
    {
        bgmManager.FadeOutMusic(6);
        bgmManager.FadeInMusic(8);
    }
}
