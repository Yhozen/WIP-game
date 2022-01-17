using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class UIDialog : MonoBehaviour
{
    public string CharName;
    public Text TextName;
    void Start()
    {
        CharName = PlayerPrefs.GetString("charName");
    }
    // Update is called once per frame

    void Update()
    {
        TextName.text = "Hi " + CharName + " Fuck you";
    }
}
