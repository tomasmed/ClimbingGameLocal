using UnityEngine;
using System.Collections;

public class t_Movement : MonoBehaviour {

    //Variables
    public float speed = 1f; //Speed multiplier by which the character will move
    public float JumpPower = 20;
    public string Axisname;
    public KeyCode JumpKey;
    public KeyCode GrabKey;


    public bool _______________________;

    private float HorizIn = 0f; //Variable to hold the Horizontal Input from player
    private bool JumpIn;

    //Grab Variable
    //[HideInInspector]
    public bool holdingOn;

    //Jump Variables
   //[HideInInspector]
    public bool grounded = true;

    //---------------------------------End of Variables

    void Start () {}

    //Re-enable jumping mechanics when we are grounded
    void OnCollisionEnter(Collision coll)
    {
        //Debug.Log(gameObject.name + " collided with: " + coll.gameObject.name);
        if (coll.gameObject.tag == "Terrain") grounded = true;
    }

    void Update()
    {
        //Obtaining Input
        HorizIn = Input.GetAxis(Axisname);
        JumpIn = Input.GetKeyDown(JumpKey);
        holdingOn = Input.GetKey(GrabKey);

        if(HorizIn != 0)
        {
            Vector3 temp = gameObject.GetComponent<Rigidbody>().velocity;
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(HorizIn, temp.y/speed, 0) * speed;

        }
        if (JumpIn && grounded)
        {
            Debug.Log("Jumping!");
            Vector3 temp = gameObject.GetComponent<Rigidbody>().velocity;
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(temp.x, JumpPower, temp.z);
            grounded = false;
        }
    }
}
