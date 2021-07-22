using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPlay : MonoBehaviour
{
    private BGMManager bgmManager;


    void Start()
    {
        bgmManager = BGMManager.instance;
        bgmManager.Stop(9);
        PlayBGM();

    }

    public void PlayBGM()
    {
        bgmManager.Play(7);
        bgmManager.SetVoulme(0.2f, 7);
    }
}
