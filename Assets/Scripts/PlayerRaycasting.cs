using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerRaycasting : MonoBehaviour
{
    public float distanceToSee;
    RaycastHit whatIHit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(this.transform.position, this.transform.forward * distanceToSee, Color.magenta);

        if(Physics.Raycast(this.transform.position, this.transform.forward, out whatIHit, distanceToSee))
        {
            Debug.Log("Currently touching " +whatIHit.collider.gameObject.name);
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Pressed primary button.");

                if (whatIHit.collider.name.Equals("TVBox"))
                {
                    GameObject.Find("OldPrice").GetComponent<Text>().text = "Was: $200";
                    GameObject.Find("NewPrice").GetComponent<Text>().text = "Now: $700";
                }
                else if (whatIHit.collider.name.Equals("Cylinder"))
                {
                    GameObject.Find("OldPrice").GetComponent<Text>().text = "Was: $200";
                    GameObject.Find("NewPrice").GetComponent<Text>().text = "Now: $700";
                }

            }
        }
        else
        {
            GameObject.Find("OldPrice").GetComponent<Text>().text = "";
            GameObject.Find("NewPrice").GetComponent<Text>().text = "";
        }
    }
}
