using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            Debug.Log("TP");
            player.transform.position = new Vector3(-9, 50, -56);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("EXIT");
            Application.Quit();
        }
    }
}
