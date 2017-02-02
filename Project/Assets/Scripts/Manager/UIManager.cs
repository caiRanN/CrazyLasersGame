using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
		StartCoroutine(DisplayText());
	}

	private void GameEndHandler(object sender, string message) {
		endObject.SetActive(true);
	}

	private IEnumerator DisplayText() {
		startObject.SetActive(true);
		yield return new WaitForSeconds(3);
		startObject.SetActive(false);
		yield return null;
	}
}
