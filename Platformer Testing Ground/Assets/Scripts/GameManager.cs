using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private Vector3 respwanPos;

    public GameManager GM;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        respwanPos = PlayerController.instance.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Respawn()
    {
        StartCoroutine(RespawnCo()); 
    }

    public IEnumerator RespawnCo()
    {
        PlayerController.instance.gameObject.SetActive(false);
        CameraController.instance.cmBrain.enabled = false;

        UiManager.instance.fadeToBlack = true;

        yield return new WaitForSeconds(2f);

        HealthManager.instance.ResetHealth();

        UiManager.instance.fadeFromBlack = true;
        
        PlayerController.instance.transform.position = respwanPos;

        CameraController.instance.cmBrain.enabled = true;

        PlayerController.instance.gameObject.SetActive(true);
    }

    public void SetSpawnPoint(Vector3 newSpawnPoint)
    {
        respwanPos = newSpawnPoint;
    }
}
