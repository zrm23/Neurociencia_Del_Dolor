﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CameraDoorScript
{
public class CameraOpenDoor : MonoBehaviour {
	public float DistanceOpen=3;
	public GameObject text;
	// Use this for initialization

	private DoorScript.Door currentdoor;
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if (Physics.Raycast (transform.position, transform.forward, out hit, DistanceOpen)) {
				if (hit.transform.GetComponent<DoorScript.Door> ()) {
					currentdoor = hit.transform.GetComponent<DoorScript.Door> ();
				text.SetActive (true);
			}else{
				currentdoor = null;
				text.SetActive (false);
			}
		}else{
			currentdoor = null;
			text.SetActive (false);
		}
	}
	public void OpenDoorFromButton(){
		if (currentdoor != null) {
			currentdoor.OpenDoor ();
		}
	}
}
}
