using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerPlay : MonoBehaviour
{
    private BGMManager bgmManager;


    void Start()
    {
        bgmManager = BGMManager.instance;
        bgmManager.Stop(7);
        PlayBGM();

    }

    public void PlayBGM()
    {
        bgmManager.Play(4);
        bgmManager.SetVoulme(0.2f, 4);
    }
}
