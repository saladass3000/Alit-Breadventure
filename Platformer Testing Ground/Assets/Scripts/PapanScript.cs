using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapanScript : MonoBehaviour
{
    public GameObject textIg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {

        if ((other.gameObject.tag == "Player"))
        {
            textIg.SetActive(true);
        }

    }
    private void OnTriggerExit(Collider other)
    {
            textIg.SetActive(false);
    }
}
