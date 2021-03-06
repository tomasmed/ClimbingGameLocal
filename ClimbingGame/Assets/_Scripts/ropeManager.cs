﻿using UnityEngine;
using System.Collections;

public class ropeManager : MonoBehaviour {
    //Draws the Rope between member1 and member2
    //Requires for Member 1 to have a LineRenderer attached
    public GameObject member1;
    public GameObject member2;
    LineRenderer rope;

	// Use this for initialization
	void Start () {
        rope = member1.GetComponent<LineRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        rope.SetPosition(0, member1.transform.position);
        rope.SetPosition(1, member2.transform.position);
	}
}
