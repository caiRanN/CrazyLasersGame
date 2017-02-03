using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityOSC;
using System.Net;
using System.Net.Sockets;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	private OSCClient client;

	// Initialize OSCClient and send GameStart event
	private void Start() {
		client = new OSCClient(IPAddress.Parse("10.200.200.58"), 1234);
		EventManager<object, string>.LaunchEvent(EventList.GameStart, this, "");
	}

	private void OnEnable() {
		EventManager<object, string>.GameEnd += GameEndHandler;
	}

	private void OnDisable() {
		EventManager<object, string>.GameEnd -= GameEndHandler;
	}


	private void GameEndHandler(object sender, string message) {
		SendMessage(1f);
		StartCoroutine(Restart(10));
	}

	private void OnDestroy() {
		client.Close();
	}

	/// <summary>
	/// Send OSC message to client
	/// </summary>
	/// <param name="value">Value.</param>
	private void SendMessage(float value) {
		OSCMessage m = new OSCMessage("/unity_trigger1");
		m.Append(value);
		client.Send(m);
	}

	/// <summary>
	/// Restart the current scene after set amount of seconds
	/// </summary>
	/// <param name="seconds">Seconds until restart</param>
	private IEnumerator Restart(float seconds) {
		yield return new WaitForSeconds(seconds);
		SceneManager.LoadScene(1);
		yield return null;
	}
}
