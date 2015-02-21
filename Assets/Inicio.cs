using UnityEngine;
using System.Collections;

public class Inicio : MonoBehaviour {


	// Update is called once per frame
	public void ChangeScene (int sceneToChangeTo) {
		Application.LoadLevel (sceneToChangeTo);
	}
}
