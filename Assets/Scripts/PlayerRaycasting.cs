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
            //Once Left Mouse Button is pressed it will display the prices.
            Debug.Log("Currently touching " +whatIHit.collider.gameObject.name);
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Pressed primary button.");
                
                //Left Shelf Prices
                if (whatIHit.collider.name.Equals("TVBox"))
                {
                    GameObject.Find("OldPrice").GetComponent<Text>().text = "Was: $350";
                    GameObject.Find("NewPrice").GetComponent<Text>().text = "Now: $780";
                }
                else if (whatIHit.collider.name.Equals("PrinterBox"))
                {
                    GameObject.Find("OldPrice").GetComponent<Text>().text = "Was: $200";
                    GameObject.Find("NewPrice").GetComponent<Text>().text = "Now: $450";
                }
                else if (whatIHit.collider.name.Equals("StartFactoryBox"))
                {
                    GameObject.Find("OldPrice").GetComponent<Text>().text = "Was: $200";
                    GameObject.Find("NewPrice").GetComponent<Text>().text = "Now: $600";
                }
                else if (whatIHit.collider.name.Equals("PortableConsoleBox"))
                {
                    GameObject.Find("OldPrice").GetComponent<Text>().text = "Was: $130";
                    GameObject.Find("NewPrice").GetComponent<Text>().text = "Now: $380";
                }
                //Right Shelf Prices
                else if (whatIHit.collider.name.Equals("SSDBox"))
                {
                    GameObject.Find("OldPrice").GetComponent<Text>().text = "Was: $99";
                    GameObject.Find("NewPrice").GetComponent<Text>().text = "Now: $299";
                }
                else if (whatIHit.collider.name.Equals("BBOXBox"))
                {
                    GameObject.Find("OldPrice").GetComponent<Text>().text = "Was: $499";
                    GameObject.Find("NewPrice").GetComponent<Text>().text = "Now: $899";
                }
                else if (whatIHit.collider.name.Equals("GPUBox"))
                {
                    GameObject.Find("OldPrice").GetComponent<Text>().text = "Was: $699";
                    GameObject.Find("NewPrice").GetComponent<Text>().text = "Now: $1,099";
                }
                else if (whatIHit.collider.name.Equals("MicrowaveBox"))
                {
                    GameObject.Find("OldPrice").GetComponent<Text>().text = "Was: $149";
                    GameObject.Find("NewPrice").GetComponent<Text>().text = "Now: $399";
                }
                else if (whatIHit.collider.name.Equals("eDonaldBox"))
                {
                    GameObject.Find("OldPrice").GetComponent<Text>().text = "Was: $999";
                    GameObject.Find("NewPrice").GetComponent<Text>().text = "Now: $1,499";
                }

            }
        }
        //If the raycaster isn't touching any of the boxes, we need to clear out the text
        else
        {
            GameObject.Find("OldPrice").GetComponent<Text>().text = "";
            GameObject.Find("NewPrice").GetComponent<Text>().text = "";
        }
    }
}
