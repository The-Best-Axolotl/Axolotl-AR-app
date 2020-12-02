using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CopyTextinGaze : MonoBehaviour
{
    public string comment;
    public InputField write;
    public GameObject inputField;
    public GameObject textDisplay;

    public void StoreName()
    {
        comment = inputField.GetComponent<Text>().text;
        textDisplay.GetComponentInChildren<TextMeshPro>().text = comment;
    }

    public void Clear()
    {
        write.text = "";
    }

}
