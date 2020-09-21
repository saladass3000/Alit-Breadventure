using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollection : MonoBehaviour
{
    
    
    private int totalRoti;
    public GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if((other.gameObject.tag == "Player"))
        {
            Destroy(gameObject);
            ScoreData.totalRoti += 1;
        }
       
    }
}
