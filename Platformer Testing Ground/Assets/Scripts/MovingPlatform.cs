using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour
{
    public float moveSpeed;
    public float comebackSpeed;
   

    // Use this for initialization
    void Start()
    {

        StartCoroutine("Move");
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    IEnumerator Move()
    {


        while (true)
        {
            yield return new WaitForSeconds(comebackSpeed);
            transform.eulerAngles += new Vector3(0, 180f, 0);
        }
    }

    
}