using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxManager : MonoBehaviour
{
    public static SfxManager instance;
    public AudioClip step;
    public AudioClip hurt;
    public AudioClip roti;
    public AudioSource audioSource;
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
        audioSource = GetComponent<AudioSource>();
    }
    private void Step()
    {
        audioSource.PlayOneShot(step); 
    }

    public void DamageSfx()
    {
        audioSource.PlayOneShot(hurt);
    }

    public void Collect()
    {
        audioSource.PlayOneShot(roti);
    }
}
