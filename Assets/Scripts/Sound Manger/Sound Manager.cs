using UnityEngine;
using System;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public Sound[] bGMusic,fXClip;
    public AudioSource bGSource,fXSource;
    public AudioMixer mixer;
    float master,music,soundFX;

      public void PlayMusic(string name,bool isLooping){
         Sound sound =     Array.Find(bGMusic,x => x.name == name);
            
            if(sound == null){
                
                print ("No sound Named: "+ name+" at "+ bGMusic.ToString());

            } 
            else{
                if(isLooping){
                        bGSource.loop = true;
                }else
                    bGSource.loop = false;   
            
                bGSource.clip = sound.clip;
                bGSource.Play();
            }

    }
    public void StopMusic(){
            bGSource.Stop();
    }
    public void PlaySoundFx(string name){
        Sound sound =  Array.Find(fXClip,x => x.name == name);
            
            if(sound == null){
                
                print ("No sound Named: "+ name+" at "+ fXSource.ToString());

            } 
            else{

                fXSource.PlayOneShot(sound.clip);
            }
        
    }

    public void VolumeSliderMaster (float volume){
         mixer.SetFloat("Master",MathF.Log10(volume)*20);
         master = MathF.Log10(volume)*20;
    }
    public void VolumeSliderSoundFx(float volume){
                mixer.SetFloat("SoundFx",MathF.Log10(volume)*20);
                soundFX = MathF.Log10(volume)*20;
    }
    public void VolumeSliderMusic(float volume){
                mixer.SetFloat("BGMusic",MathF.Log10(volume)*20);
                music = MathF.Log10(volume)*20;
    }
    public float ReturnMasterVolume(){
        
        return master;
    }
    public float ReturnSoundFx(){

        return soundFX;
    }
    public float ReturnMusic(){
        return music;
    }
}