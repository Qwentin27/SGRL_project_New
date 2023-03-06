using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoReader : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Button playButton;

    void Start()
    {
        playButton.onClick.AddListener(Play);
    }

    void Play()
    {
        videoPlayer.Play();
    }
}
