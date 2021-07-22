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
            //DontDestroyOnLoad(gameObject);
        }
    }
    #endregion singleton


    void Start()
    {
        if(instance == this)
            source = GetComponent<AudioSource>();
    }

    private int _currentPlayTrack = -1; // -1은 아무것도 재생중이지 않은 것
    public void Play(int _playMusicTrack)
    {
        Debug.Log("누가 재생을 호출함 " + _playMusicTrack);
        if  (_playMusicTrack == _currentPlayTrack)
            return;

        _currentPlayTrack = _playMusicTrack;
        source.volume = 1f;
        source.clip = clips[_playMusicTrack];
        source.Play();
    }

    public void Pause(int _playMusicTrack)
    {
        source.clip = clips[_playMusicTrack];
        source.Pause();
    }

    public void UnPause(int _playMusicTrack)
    {
        source.clip = clips[_playMusicTrack];
        source.UnPause();
    }
    public void SetVoulme(float _volume, int _playMusicTrack)
    {
        source.clip = clips[_playMusicTrack];
        source.volume = _volume;
    }

    public void Stop(int _playMusicTrack)
    {
        Debug.Log("누가 정지를 호출함 " + _playMusicTrack);
        _currentPlayTrack = -1;
        source.clip = clips[_playMusicTrack];
        source.Stop();
    }

    public void FadeOutMusic(int _playMusicTrack)
    {
        Debug.Log("누가 페이드아웃를 호출함 " + _playMusicTrack);
        _currentPlayTrack = -1;
        StopAllCoroutines();
        source.clip = clips[_playMusicTrack];
        StartCoroutine(FadeOutMusicCoroutine());
    }

    public void FadeInMusic(int _playMusicTrack)
    {
        Debug.Log("누가 페이드인를 호출함 " + _playMusicTrack);
        if (_playMusicTrack == _currentPlayTrack)
            return;

        _currentPlayTrack = _playMusicTrack;

        StopAllCoroutines();
        source.clip = clips[_playMusicTrack];
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

