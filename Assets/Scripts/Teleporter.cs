using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Teleporter : MonoBehaviour
{
    public GameObject player;
    public string nextLevel;

    public bool canTeleport = false;

    public TextMeshProUGUI doorOpenDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(GameObject.FindGameObjectsWithTag("Hamster").Length <= 0)
        {
            canTeleport = true;
            Debug.Log("TELEPORTER IS ACTIVE!!");
            doorOpenDisplay.gameObject.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && canTeleport)
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
}
