using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OptionMenu : MonoBehaviour
{   
    public AudioMixer SoundfxMixer;
    public AudioMixer MusicMixer;
    public void SetSoundVol (float sfx){
        SoundfxMixer.SetFloat("volumefx", sfx);
    }
    public void SetMusicVol (float msc){
        MusicMixer.SetFloat("volumemsc", msc);
    }

    public void Low(){
        QualitySettings.SetQualityLevel(0);
    }
    public void Med(){
        QualitySettings.SetQualityLevel(1);
    }
    public void High(){
        QualitySettings.SetQualityLevel(2);
    }
}
