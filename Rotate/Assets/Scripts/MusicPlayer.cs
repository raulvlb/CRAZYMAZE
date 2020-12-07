using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{

    public AudioSource AudioSource;

    private float musicvolume;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource = MusicContinue.Instance.gameObject.GetComponent<AudioSource>();
        musicvolume = AudioSource.volume;
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource.volume = musicvolume;
    }

    public void UpdateVolume (float volume){
        musicvolume = volume;
    }
}
