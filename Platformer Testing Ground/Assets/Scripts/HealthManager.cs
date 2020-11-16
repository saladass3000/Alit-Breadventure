﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public static HealthManager instance;
    public int currentHealth, maxHealth;
    public GameObject hp1, hp2, hp3, hp4, hp5, panelLose;
    public float invincibleLength = 2f;
    private float invincCounter;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(invincCounter > 0)
        {
            invincCounter -= Time.deltaTime;

                for (int i = 0; i < PlayerController.instance.playerPieces.Length; i++)
                {
                    if(Mathf.Floor(invincCounter * 5f) % 2 == 0)
                    {
                        PlayerController.instance.playerPieces[i].SetActive(true);
                    }
                    else
                    {
                        PlayerController.instance.playerPieces[i].SetActive(false);
                    }
                    if (invincCounter <= 0)
                    {
                        PlayerController.instance.playerPieces[i].SetActive(true);
                    }
                
            }
        }
    }

    public void Hurt()
    {
        if(invincCounter <= 0)
        {
            currentHealth--;

         if(currentHealth <= 4)
         {
                hp1.SetActive(false);
         }
          if(currentHealth <= 3)
         {
                hp2.SetActive(false);
         }
           if(currentHealth <= 2)
         {
                hp3.SetActive(false);
         }
            if(currentHealth <= 1)
         {
                hp4.SetActive(false);
         }
         
        if (currentHealth <= 0)
         {
            hp5.SetActive(false);
            currentHealth = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            panelLose.SetActive(true);
         }
         else
         {
            PlayerController.instance.Knockback();
            invincCounter = invincibleLength;

           
          }

        }
    }
    public void ResetHealth()
    {
        currentHealth = maxHealth;
    }
}
