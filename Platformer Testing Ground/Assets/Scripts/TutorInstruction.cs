using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorInstruction : MonoBehaviour
{
    public GameObject text;
    public GameObject tutorBox;
    public int waitTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {

        if ((other.gameObject.tag == "Player"))
        {
            Instruction();
        }

    }

    public void Instruction()
    {
        StartCoroutine(Tutor());
    }
    
    public IEnumerator Tutor()
    {
        text.SetActive(true);
        yield return new WaitForSeconds(waitTime);
        text.SetActive(false);
        tutorBox.SetActive(false);
    }
}
