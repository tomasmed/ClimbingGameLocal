using UnityEngine;
using System.Collections;


public class calcPosition : MonoBehaviour {
    //This Function takes care of moving the camera around to the midpoint between player1 and player2 (including a possible y offset)

    public Transform player1;
    public Transform player2;

    Camera cam;

    public float yOffset = 0.0f;

    //What are we caching the camera for?
	void Start () {    
        cam = GetComponent<Camera>();
	}
	
	void Update () {
        // Have the camera look at the point inbetween the two players
        Vector3 newPos = transform.position;
        newPos.x = player1.position.x + (player2.position.x - player1.position.x) / 2;
        newPos.y = (player1.position.y + (player2.position.y - player1.position.y) / 2) + yOffset;
        transform.position = newPos;
	}
}
