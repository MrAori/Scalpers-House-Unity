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
                    GameObject.Find("ProductTitle").GetComponent<Text>().text = "Sam & Co Bravo Television";
                    GameObject.Find("ProductPrice").GetComponent<Text>().text = "Was: $350\nNow: $780";
                }
                else if (whatIHit.collider.name.Equals("PrinterBox"))
                {
                    GameObject.Find("ProductTitle").GetComponent<Text>().text = "SG LaserJet (5400x Model)";
                    GameObject.Find("ProductPrice").GetComponent<Text>().text = "Was: $200\nNow: $450";
                }
                else if (whatIHit.collider.name.Equals("StartFactoryBox"))
                {
                    GameObject.Find("ProductTitle").GetComponent<Text>().text = "NONY StartFactory";
                    GameObject.Find("ProductPrice").GetComponent<Text>().text = "Was: $200\nNow: $600";
                }
                else if (whatIHit.collider.name.Equals("PortableConsoleBox"))
                {
                    GameObject.Find("ProductTitle").GetComponent<Text>().text = "NONY Nova Portable";
                    GameObject.Find("ProductPrice").GetComponent<Text>().text = "Was: $130\nNow: $380";
                }
                //Right Shelf Prices
                else if (whatIHit.collider.name.Equals("SSDBox"))
                {
                    GameObject.Find("ProductTitle").GetComponent<Text>().text = "Sam & Co SSD (1TB)";
                    GameObject.Find("ProductPrice").GetComponent<Text>().text = "Was: $99\nNow: $299";
                }
                else if (whatIHit.collider.name.Equals("BBOXBox"))
                {
                    GameObject.Find("ProductTitle").GetComponent<Text>().text = "BBOX 2.0";
                    GameObject.Find("ProductPrice").GetComponent<Text>().text = "Was: $499\nNow: $899";
                }
                else if (whatIHit.collider.name.Equals("GPUBox"))
                {
                    GameObject.Find("ProductTitle").GetComponent<Text>().text = "XLB SILVER (8GB)";
                    GameObject.Find("ProductPrice").GetComponent<Text>().text = "Was: $699\nNow: $1,099";
                }
                else if (whatIHit.collider.name.Equals("MicrowaveBox"))
                {
                    GameObject.Find("ProductTitle").GetComponent<Text>().text = "Johnsons Microwave";
                    GameObject.Find("ProductPrice").GetComponent<Text>().text = "Was: $149\nNow: $399";
                }
                else if (whatIHit.collider.name.Equals("eDonaldBox"))
                {
                    GameObject.Find("ProductTitle").GetComponent<Text>().text = "Maple eDonald";
                    GameObject.Find("ProductPrice").GetComponent<Text>().text = "Was: $999\nNow: $1,499";
                }
                //Since the text may stay when looking at the selfs, we need this as a workaround
                else if (whatIHit.collider.name.Equals("RightShelf"))
                {
                    GameObject.Find("ProductTitle").GetComponent<Text>().text = "";
                    GameObject.Find("ProductPrice").GetComponent<Text>().text = "";
                }
                else if (whatIHit.collider.name.Equals("LeftShelf"))
                {
                    GameObject.Find("ProductTitle").GetComponent<Text>().text = "";
                    GameObject.Find("ProductPrice").GetComponent<Text>().text = "";
                }

            }
        }
        //If the raycaster isn't touching any of the boxes, we need to clear out the text
        else
        {
            GameObject.Find("ProductTitle").GetComponent<Text>().text = "";
            GameObject.Find("ProductPrice").GetComponent<Text>().text = "";
        }
    }
}
