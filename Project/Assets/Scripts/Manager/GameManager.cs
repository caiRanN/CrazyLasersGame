using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityOSC;
using System.Net;
using System.Net.Sockets;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public AudioClip clip;
	public AudioSource source;
	private OSCClient client;

	private void Start() {
		client = new OSCClient(IPAddress.Parse("10.200.200.58"), 1234);
		EventManager<object, string>.LaunchEvent(EventList.GameStart, this, "");
	}

	private void OnEnable() {
		EventManager<object, string>.GameStart += GameStartHandler;
		EventManager<object, string>.GameEnd += GameEndHandler;
	}

	private void OnDisable() {
		EventManager<object, string>.GameStart -= GameStartHandler;
		EventManager<object, string>.GameEnd -= GameEndHandler;
	}

	private void GameStartHandler(object sender, string message) {
		Debug.Log("Game Start");
	}

	private void GameEndHandler(object sender, string message) {
		SendMessage();
	}

	private void OnDestroy() {
		client.Close();
	}

	/// <summary>
	/// Send OSC message
	/// </summary>
	private void SendMessage() {
		OSCMessage m = new OSCMessage("/unity_trigger1");
		m.Append(1f);
		client.Send(m);
	}

	/// <summary>
	/// Restart the scene after 10 seconds
	/// </summary>
	private IEnumerator Restart() {
		yield return new WaitForSeconds(10);
		SceneManager.LoadScene(1);
	}
}
