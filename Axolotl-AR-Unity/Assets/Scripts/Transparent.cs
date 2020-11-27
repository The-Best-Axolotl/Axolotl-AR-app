using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transparent : MonoBehaviour
{
    public GameObject bimModel;

    public Material plumbView;
    public Material strucView;
    public Material mechaView;
    public Material electView;

    public Toggle plumbBt;
    public Toggle strucBt;
    public Toggle mechaBt;
    public Toggle electBt;

    void Start()
    {
        bimModel = gameObject;
    }

    public void PlumbBtOn()
    {
        if (plumbBt.isOn)
        {
            ChangeAlphaValue(plumbView, 1f);
        }
        else
        {
            ChangeAlphaValue(plumbView, 0.05f);
        }
    }

    public void StrucBtOn()
    {
        if (strucBt.isOn)
        {
            ChangeAlphaValue(strucView, 1f);
        }
        else
        {
            ChangeAlphaValue(strucView, 0.05f);
        }
    }

    public void MechaBtOn()
    {
        if (mechaBt.isOn)
        {
            ChangeAlphaValue(mechaView, 1f);
        }
        else
        {
            ChangeAlphaValue(mechaView, 0.05f);
        }
    }

    public void ElectBtOn()
    {
        if (electBt.isOn)
        {
            ChangeAlphaValue(electView, 1f);
        }
        else
        {
            ChangeAlphaValue(electView, 0.05f);
        }
    }

    public void ChangeAlphaValue(Material mat, float alphavalue)
    {
        Color oldColor = mat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphavalue);
        mat.SetColor("_Color", newColor);
    }

}
