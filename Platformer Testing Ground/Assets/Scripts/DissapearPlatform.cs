using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissapearPlatform : MonoBehaviour
{
    public GameObject platform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            DissPlatform();
        }
    }

    public void DissPlatform()
    {
        StartCoroutine(Diss());
    }

    public IEnumerator Diss()
    {
        yield return new WaitForSeconds(1f);
        platform.gameObject.SetActive(false);

        yield return new WaitForSeconds(2f);
        platform.gameObject.SetActive(true);
    }
}
