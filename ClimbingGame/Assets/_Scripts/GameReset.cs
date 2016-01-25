using UnityEngine;
using System.Collections;

public class GameReset : MonoBehaviour {
    //This Script can be attached to the main Camera to provide a backdoor into Tomas_Test lvl;

	void Update () {
        if (Input.GetKeyDown(KeyCode.F3)) Application.LoadLevel("Tomas_Test");
	}
}
