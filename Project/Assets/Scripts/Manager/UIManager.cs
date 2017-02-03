using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles the User Interface and displays messages when certain events are called
/// </summary>
public class UIManager : MonoBehaviour {

	public GameObject startObject;
	public GameObject endObject;

	private void OnEnable() {
		EventManager<object, string>.GameStart += GameStartHandler;
		EventManager<object, string>.GameEnd += GameEndHandler;
	}

	private void OnDisable() {
		EventManager<object, string>.GameStart -= GameStartHandler;
		EventManager<object, string>.GameEnd -= GameEndHandler;
	}

	private void GameStartHandler(object sender, string message) {
		StartCoroutine(DisplayText(3f));
	}

	private void GameEndHandler(object sender, string message) {
		endObject.SetActive(true);
	}

	/// <summary>
	/// Activates a GameObject for a amount of seconds and turns it off again
	/// </summary>
	/// <returns>null</returns>
	/// <param name="seconds">Amount of seconds before deactivation</param>
	private IEnumerator DisplayText(float seconds) {
		startObject.SetActive(true);
		yield return new WaitForSeconds(seconds);
		startObject.SetActive(false);
		yield return null;
	}
}
