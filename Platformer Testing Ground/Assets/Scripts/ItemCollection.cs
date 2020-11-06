using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollection : MonoBehaviour
{

    public float rotateSpeed;
    private int totalRoti;
    public GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(new Vector3(0, rotateSpeed * Time.deltaTime, 0));
    }

    private void OnTriggerEnter(Collider other)
    {
        if((other.gameObject.tag == "Player"))
        {
            SfxManager.instance.Collect();
            Destroy(gameObject);
            ScoreData.totalRoti += 1;
        }
       
    }
}
