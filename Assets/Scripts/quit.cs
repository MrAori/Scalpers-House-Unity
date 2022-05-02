using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            GameObject.Find("QuitTitle").GetComponent<Text>().text = "Are you sure you want to Exit?'\n Yes(Y) | No (N)";

            if(Input.GetKeyDown(KeyCode.Y)){
                Application.Quit();
            }

            if(Input.GetKeyDown(KeyCode.N)){
                Debug.Log("Pressed N");
                GameObject.Find("QuitTitle").GetComponent<Text>().text = "";
            }

            
        }

    }
}
