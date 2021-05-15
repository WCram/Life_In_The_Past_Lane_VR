using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WearMaskScript : MonoBehaviour
{
    public GameObject wearMask;


    private String maskName = "Hold_Mask";

    private void OnTriggerEnter(Collider other)
    {
        GameObject go = other.gameObject;
        if (other.name.Equals(maskName))
        {
            go.SetActive(false);
            wearMask.SetActive(true);
        }
    }
} // class
