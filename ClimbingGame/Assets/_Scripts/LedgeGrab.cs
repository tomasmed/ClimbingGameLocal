using UnityEngine;
using System.Collections;

public class LedgeGrab : MonoBehaviour {
    //This Function will deal wiht the mechanics of terrain ledges, by using a box collider to provide an area to "hold on"


    //Variables

    private bool grabbing = false;


    
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            coll.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
            Debug.Log("The Player passed a Ledge");
            //If the Player is pressing the button to hold On to the ledge freeze his velocity and ground him so he can jump
            if (coll.gameObject.GetComponent<t_Movement>().holdingOn == true)
            {
                Debug.Log("The Player is trying to grab onto the Ledge");
                grabbing = true;
                coll.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
                coll.gameObject.GetComponent<t_Movement>().grounded = true;
            }
            else
            {
                Debug.Log("Player did not hold on");
                
            }
        }
    }

    void OnTriggerExit(Collider coll)
    {
        coll.gameObject.GetComponent<Renderer>().material.color = Color.red;
        if (grabbing == true)
        {
            grabbing = false;
        }
    }
}
