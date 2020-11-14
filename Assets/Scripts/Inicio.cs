using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Inicio : MonoBehaviour {

	public void Salir (bool PressExit) {
		if (PressExit) Application.Quit();
	}

	public void ChangeScene(int sceneToChangeTo) {
		SceneManager.LoadScene(sceneToChangeTo, LoadSceneMode.Single);
	}
    public void Update () {
	   if (Input.GetKey("escape")) {
		   ChangeScene(2);
		}
	}
}