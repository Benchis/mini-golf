using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    [SerializeField] Slider volumeSliderMusic;
    [SerializeField] Slider volumeSliderSFX;

    void Start()
    {
        
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSliderMusic.value;

        AudioListener.volume = volumeSliderMusic.value;
    }

 
}
