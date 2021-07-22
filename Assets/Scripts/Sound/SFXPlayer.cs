using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlayer : MonoBehaviour
{
    SoundManager soundManager;

    public string clickBT_SFX;
    public string moveScene_SFX;
    public string getItem_SFX;
    public string nextText_SFX;



    void Start()
    {
        soundManager = SoundManager.instance;
    }


    public void Click_SFX()
    {
        soundManager.PlaySFX("clickBT_SFX");
    }
    public void MoveScene_Effect()
    {
        soundManager.PlaySFX("moveScene_SFX");
    }
    public void GetItme_SFX()
    {
        soundManager.PlaySFX("getItem_SFX");
    }

    public void NextText_SFX()
    {
        soundManager.PlaySFX("nextText_SFX");
    }
}
