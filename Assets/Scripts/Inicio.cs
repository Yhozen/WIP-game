﻿using UnityEngine;
using System.Collections;

public class Inicio : MonoBehaviour {

	public void Salir (bool PressExit) {
		if (PressExit) Application.Quit();
	}

	public void ChangeScene (int sceneToChangeTo) {
		Application.LoadLevel (sceneToChangeTo);
	}
    public void Update () {
	   if (Input.GetKey ("escape")) {
		   ChangeScene(2);
	}
}
}