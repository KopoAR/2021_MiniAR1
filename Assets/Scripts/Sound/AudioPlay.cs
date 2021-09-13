using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioPlay : MonoBehaviour
{
    public string clickBT_Effect;
    public string moveScene_Effect;
    public string getItem_Effect;
    public string nextText_Effect;


    private AudioManager audioManager;
    //private BGMManager bgmManager;

    //public int playMusicTrack;

    void Start()
    {
        StartCoroutine(TryGetManager());
    }

    private IEnumerator TryGetManager()
    {
        while(AudioManager.instance == null)
        {
            yield return new WaitForFixedUpdate();
        }

        audioManager = AudioManager.instance;
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

    public void NextText_Effect()
    {
        audioManager.Play(nextText_Effect);
    }
}
