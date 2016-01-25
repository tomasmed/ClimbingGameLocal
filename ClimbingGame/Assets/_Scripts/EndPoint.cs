using UnityEngine;
using System.Collections;

public class EndPoint : MonoBehaviour {
    //This Script will take care of everyhting that needs to be taken care of when the end of a level is reached 

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Application.LoadLevel("Victory");
        }
    }
}
