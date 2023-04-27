using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Volumen : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    [Range(0,1)]
    private float volumenF;
    public Slider sliderVolum;
    public Slider sliderAcel;

    private void Awake()
    {
        sliderVolum.value = 1;
        sliderAcel.value = 1;
    }
    private void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    private void Update()
    {
        VolumenM();
        volumenF = sliderVolum.value;
    }

    public void VolumenM()
    {
        videoPlayer.SetDirectAudioVolume(0, volumenF);
    }

    public void OnMute()
    {
        videoPlayer.SetDirectAudioMute(0, true);
    }

    public void ExitMute()
    {
        videoPlayer.SetDirectAudioMute(0, false);
    }
}
