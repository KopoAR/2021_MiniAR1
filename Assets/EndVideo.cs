using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;

public class EndVideo : MonoBehaviour
{
    [SerializeField] private VideoPlayer _videoPlayer;
    public UnityEvent _finishEvent;

    private void OnEnable()
    {
        _videoPlayer.loopPointReached += OnEndVideo;
    }

    private void OnEndVideo(VideoPlayer vp)
    {
        Debug.Log("finish");
        if(_finishEvent != null)
        {
            _finishEvent.Invoke();
        }
    }
}
