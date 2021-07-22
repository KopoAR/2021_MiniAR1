using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMPlayer : MonoBehaviour
{
    SoundManager soundManager;

    public string intro_BGM;

    void Start()
    {
        soundManager = SoundManager.instance;
        DontDestroyOnLoad(gameObject);
        PlayBGM();
    }

    public void PlayBGM()
    {
        soundManager.PlayBGM(intro_BGM);
        //soundManager.SetVoulme(0.2f, 9);
    }
}


