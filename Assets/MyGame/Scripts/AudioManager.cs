using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip upClip;
    public AudioClip downClip;
    public AudioClip leftClip;
    public AudioClip rightClip;
    public AudioClip spaceClip;
    public AudioClip wClip, aClip, sClip, dClip;

    public AudioSource audioSource;

    void Start()
    {
        //audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            PlaySound(upClip);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            PlaySound(downClip);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            PlaySound(leftClip);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            PlaySound(rightClip);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            PlaySound(spaceClip);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            PlaySound(wClip);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            PlaySound(aClip);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            PlaySound(sClip);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            PlaySound(dClip);
        }
    }

    void PlaySound(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }
}
