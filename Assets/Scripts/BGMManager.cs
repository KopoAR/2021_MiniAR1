using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    static public BGMManager instance;

    public AudioClip[] clips;

    private AudioSource source;

    private WaitForSeconds waitTime = new WaitForSeconds(0.01f);

    #region singleton
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }
    #endregion singleton


    void Start()
    {
        if(instance == this)
            source = GetComponent<AudioSource>();
    }

    public void Play(int _playMusicTrack)
    {
        source.volume = 1f;
        source.clip = clips[_playMusicTrack];
        source.Play();
    }
    public void Pause()
    {
        source.Pause();
    }

    public void UnPause()
    {
        source.UnPause();
    }
    public void SetVoulme(float _volume)
    {
        source.volume = _volume;
    }

    public void Stop()
    {
        source.Stop();
    }

    public void FadeOutMusic()
    {
        StopAllCoroutines();
        StartCoroutine(FadeOutMusicCoroutine());
    }

    public void FadeInMusic()
    {
        StopAllCoroutines();
        StartCoroutine(FadeInMusicCoroutine());
    }


    IEnumerator FadeOutMusicCoroutine()
    {
        for (float i = 1.0f; i >= 0f; i-=0.01f)
        {
            source.volume = i;
            yield return waitTime;
        }
    }

    IEnumerator FadeInMusicCoroutine()
    {
        for (float i = 0f; i <= 1.0f; i += 0.01f)
        {
            source.volume = i;
            yield return waitTime;
        }
    }

}

