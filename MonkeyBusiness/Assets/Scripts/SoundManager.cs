using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public List<AudioSource> SoundSources;
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
        DontDestroyOnLoad(transform.gameObject);
    }

    public void PlaySound(int i)
    {
        SoundSources[i].Play();
    }
    public void StopSound(int i)
    {
        SoundSources[i].Stop();
    }
}
