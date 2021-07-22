using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitlePlay : MonoBehaviour
{
    private BGMManager bgmManager;


    void Start()
    {
        bgmManager = BGMManager.instance;
        PlayBGM();

    }

    public void PlayBGM()
    {
        bgmManager.Play(0);
        bgmManager.SetVoulme(0.2f, 0);
    }
}
