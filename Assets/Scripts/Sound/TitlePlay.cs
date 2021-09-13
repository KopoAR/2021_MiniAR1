using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitlePlay : MonoBehaviour
{
    private BGMManager bgmManager;
    public int bgmNum;


    void Start()
    {
        bgmManager = BGMManager.instance;
        PlayBGM(bgmNum);

    }

    public void PlayBGM(int n)
    {
        bgmManager.Play(n);
        bgmManager.SetVoulme(0.2f, n);
    }
}
