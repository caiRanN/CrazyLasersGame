using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HKUECT;

public class GateController : MonoBehaviour {

	public OSCReceiver receiver;
	public bool requiresAudience = false;

	[Range(0, 12)]
	public int oscValue;
	[Range(0, 12)]
	public int audienceOscValue;

	private void Update() {
		GateHandler();
	}
		
	private bool ShouldOpenDoor(float value) {
		return (value == 1);
		return (value == 0);
	}

	/// <summary>
	/// Check if the gate requires multiple buttons to be pressed simultaneously
	/// and open door if the value returns true
	/// </summary>
	private void GateHandler() {
		bool playerOpenGate = ShouldOpenDoor((float)receiver.GetValue(oscValue));
		bool audienceOpenGate = ShouldOpenDoor((float)receiver.GetValue(audienceOscValue));

		if(!requiresAudience) {
			if(playerOpenGate) {
				gameObject.SetActive(false);
			}
		} else {
			if(playerOpenGate && audienceOpenGate) {
				gameObject.SetActive(false);
			}
		}
	}
}
