using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    public string clickBT_Effect;
    public string moveScene_Effect;
    public string getItem_Effect;

    //public string correctPW_Effect;
    //public string failPW_Effect;

    private AudioManager audioManager;
    private BGMManager bgmManager;

    public int playMusicTrack;

    void Start()
    {
        audioManager = AudioManager.instance;
        bgmManager = BGMManager.instance;

        bgmManager.Play(playMusicTrack);
        bgmManager.SetVoulme(0.2f);
    }

    public void Click_Effect()
    {
        audioManager.Play(clickBT_Effect);
    }


    public void MoveScene_Effect()
    {
        audioManager.Play(moveScene_Effect);
    }


    public void GetItme_Effect()
    {
        audioManager.Play(getItem_Effect);
    }



    //public void Correct_Effect()
    //{
    //    audioManager.Play(correctPW_Effect);
    //}

    //public void Fail_Effect()
    //{
    //    audioManager.Play(failPW_Effect);
    //}

}
