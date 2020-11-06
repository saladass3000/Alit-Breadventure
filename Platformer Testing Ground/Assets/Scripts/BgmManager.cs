using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmManager : MonoBehaviour
{
    public static BgmManager Instance { get; private set; } = null;
    public AudioSource menuBGM;
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            Instance = this;
        }




        DontDestroyOnLoad(gameObject);
    }
}
