using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CopyText : MonoBehaviour
{
    public string comment;
    public InputField write;
    public GameObject inputField;
    public GameObject textDisplay;

    public void StoreName()
    {
        comment = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<TextMeshPro>().text = comment;
    }    

    public void Clear()
    {
        write.text = "";
    }

}
