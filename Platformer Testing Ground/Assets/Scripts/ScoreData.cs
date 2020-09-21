using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreData : MonoBehaviour
{
    public GameObject jumlahRoti;
    public static int totalRoti;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jumlahRoti.GetComponent<Text>().text = "" + totalRoti;
    }
}
