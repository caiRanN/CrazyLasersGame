using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

	private void OnTriggerEnter(Collider col) {
		if(col.tag == "Player") {
			Debug.Log("player killed");
			EventManager<object, string>.LaunchEvent(EventList.GameEnd, this, "You died by a laser!");
		}
	}
}
