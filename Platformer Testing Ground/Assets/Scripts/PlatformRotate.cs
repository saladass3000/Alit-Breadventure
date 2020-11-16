using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotate : MonoBehaviour
{
    public GameObject Player;
    public float rotateSpeed;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, rotateSpeed * Time.deltaTime, 0));
    }
    void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Player"))
        {
            Debug.Log("Parent");
            Player.transform.parent = transform;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if ((other.gameObject.tag == "Player"))
        {
            Debug.Log("Unparent");
            Player.transform.parent = null;
        }
    }
}
