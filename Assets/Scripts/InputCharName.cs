using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class InputCharName : MonoBehaviour {

public Text  charText;
// Use this for initialization
void Start () {
charText = GameObject.Find("CharText").GetComponent<Text>();
}

public void CharacterField(string inputFieldString) {
charText.text = inputFieldString;
}
}
