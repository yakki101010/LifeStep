using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TMP_Dropdown graphicsDropdown;
    public Slider masterVol, musicVol, sfxVol;
    public AudioMixer mainAudioMixer;


    public void ChangeGraphicsQuality()
    {
        QualitySettings.SetQualityLevel(graphicsDropdown.value);
    }
    public void ChangeMasterVolume()
    {
        mainAudioMixer.SetFloat("MasterVol", masterVol.value);
    }
    public void ChangeMusicVolume()
    {
        mainAudioMixer.SetFloat("MusicVol", masterVol.value);
    }

    public void ChangeSfxVolume()
    {
        mainAudioMixer.SetFloat("SfxVol", masterVol.value);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
