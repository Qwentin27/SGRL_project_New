using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoController : MonoBehaviour
{
    private RawImage rawImage;

    void Start()
    {
        rawImage = GetComponent<RawImage>();
        rawImage.enabled = false;
    }

    public void PlayVideo()
    {
        rawImage.enabled = true;
    }
}
