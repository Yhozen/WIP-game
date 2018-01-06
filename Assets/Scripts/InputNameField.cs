using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InputNameField : MonoBehaviour {
	public Text  charText;
	// Use this for initialization
	void Start () {
	}

	public void CharacterField(string inputFieldString) {
		charText.text = inputFieldString;
	}
	public void ConfirmEver() {
	  if(charText.text.Length >= 2) PlayerPrefs.SetString("charName", charText.text);
	}
}
