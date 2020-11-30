using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CopyText : MonoBehaviour
{
    Transform cam;
    Vector3 targetPosition = Vector3.zero;
    public GameObject equipPrefab;
    public string comment;
    public InputField write;
    public GameObject inputField;
    //public GameObject textDisplay;

    void Start()
    {
        cam = Camera.main.transform;
    }
    
    public void PlaceNote()
    {

        targetPosition = cam.transform.position;
        targetPosition.x = targetPosition.x + 1;
        targetPosition.z = targetPosition.z + 1;
        targetPosition.y = targetPosition.y - 1;
        GameObject go = (GameObject)Instantiate(equipPrefab, targetPosition, Quaternion.identity);
    }
    public void StoreName()
    {
        comment = inputField.GetComponent<Text>().text;
        equipPrefab.GetComponentInChildren<TextMeshPro>().text = comment;
    }    

    public void Clear()
    {
        write.text = "";
    }

}
