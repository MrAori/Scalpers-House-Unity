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

                if (whatIHit.collider.name.Equals("OtherCylinder"))
                {
                    GameObject.Find("PriceDifference").GetComponent<Text>().text = "Price: $200";
                }
                else if (whatIHit.collider.name.Equals("Cylinder"))
                {
                    GameObject.Find("PriceDifference").GetComponent<Text>().text = "Price: $100";
                }

            }
        }
        else
        {
            GameObject.Find("PriceDifference").GetComponent<Text>().text = "";
        }
    }
}
