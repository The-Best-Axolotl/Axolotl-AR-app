using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class Gaze : MonoBehaviour
{
    List<InfoBehavior> infos = new List<InfoBehavior>();

    void Start()
    {
        infos = FindObjectsOfType<InfoBehavior>().ToList();  
    }

    void Update()
    {
        if (Physics.Raycast(transform.position,transform.forward, out RaycastHit hitt))
        {
            GameObject go = hitt.collider.gameObject;
            if (go.CompareTag("hasInfo"))
            {
                print("HERE");
                Openinfo(go.GetComponent<InfoBehavior>());
            }
        }
        else
        {
            CloseAll();
        }
    }
    void Openinfo(InfoBehavior desiredInfo)
    {
        foreach(InfoBehavior info in infos)
        {
            if(info == desiredInfo)
            {
                info.OpenInfo();
            }
            else
            {
                info.CLoseInfo();
            }
        }
    }

    void CloseAll()
    {
        foreach (InfoBehavior info in infos)
        {
            info.CLoseInfo();
        }
    }
}
