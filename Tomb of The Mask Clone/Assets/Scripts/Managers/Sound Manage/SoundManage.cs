using UnityEngine.Audio;
using UnityEngine;
using System;
using System.Collections.Generic;

public class SoundManage : MonoBehaviour
{
    [Header("Sound Clips:")]
    [SerializeField] private Sound[] sounds;

    private Dictionary<string, Sound> dictionary = new Dictionary<string, Sound>();

    public static SoundManage instance;

    void Awake()
    {
            SetInstance();
            AddSoundClips();
    }

    void SetInstance()
    {
            if(instance == null)
            {
                instance = this;
            }

            else
            {
                Destroy(gameObject);
                return;
            }
    } 

    void AddSoundClips()
    {
        for(int i = 0 ; i < sounds.Length; i++)
        { 
            sounds[i].source = gameObject.AddComponent<AudioSource>();
            sounds[i].source.clip = sounds[i].clip;
            sounds[i].source.volume = sounds[i].volume;
            sounds[i].source.pitch = sounds[i].pitch;
            sounds[i].source.loop = sounds[i].loop;
            sounds[i].source.playOnAwake = sounds[i].canPlayOnAwake;

            dictionary[sounds[i].name] = sounds[i];
        }
    }

    void OnDestroy()
    {
            instance = null;
    }


    public void PlaySound(string name)
    {

            if(dictionary.ContainsKey(name))
            {
                dictionary[name].source.Play();
            }

            else
            return;
    }



}
    
