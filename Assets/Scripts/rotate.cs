using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RotateZ(){
		this.transform.Rotate (0, 0, 90);
	}

	public void RotateY(){
		this.transform.Rotate (0, 90, 0);
	}
}
