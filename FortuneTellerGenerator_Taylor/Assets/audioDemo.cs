using UnityEngine;
using System.Collections.Generic;

public class audioDemo : MonoBehaviour
{

    //public AudioSource bgMusic;
    public AudioSource sxButton;

    //to make list of sound effects to choose from
    //public AudioSource funnySounds;
    //public List<AudioClip> soundEffects;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayTheMusic()
    {
        sxButton.Play();
        //referencing sound effects list
        //funnySounds.clip=soundEffects[1];
        //OR funnySounds.clip=soundEffects[Random.Range(0,soundEffects.Count)];
        //funnySounds.Play();

    }
}
