using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour, TimedInputHandler {

	public void HandleTimedInput(){
		RotateY ();
	}

	public void RotateZ(){
		this.transform.Rotate (0, 0, 90);
	}

	 void RotateY(){
		this.transform.Rotate (0, 90, 0);
	}
}
