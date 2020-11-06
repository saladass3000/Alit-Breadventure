using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    public GameObject next;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Player"))
        {
            GameManager.instance.Finish();
            ScoreData.totalRoti = 0;
            next.SetActive(true);
        }

    }
}
