using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroPlay : MonoBehaviour
{
    private BGMManager bgmManager;


    void Start()
    {
        bgmManager = BGMManager.instance;
        bgmManager.Stop(0);
        PlayBGM();

    }

    public void PlayBGM()
    {
        bgmManager.Play(9);
        bgmManager.SetVoulme(0.2f, 9);
    }
}
