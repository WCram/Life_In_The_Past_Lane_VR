using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class LightBulbSocketEvent : MonoBehaviour
{

    // public GameObject loop;

    public GameObject subwayStrap;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger");
        GameObject go = other.gameObject;

        if (go.name.Equals("LightBulb"))
        {
            go.GetComponent<SphereCollider>().enabled = false;
            subwayStrap.transform.position += new Vector3(0, 1.7f, 0);
        }
    } // OnTrigerEnter()
    
    
} // class
