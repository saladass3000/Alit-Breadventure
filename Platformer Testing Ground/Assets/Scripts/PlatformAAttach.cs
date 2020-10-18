using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAAttach : MonoBehaviour
{
    public GameObject Player;

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
