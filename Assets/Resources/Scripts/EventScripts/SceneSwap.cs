using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.XR;

public class SceneSwap : MonoBehaviour
{

    public InputDevice device;

    private HandPrescence hand;

    public GameObject room1;
    public GameObject room2;

    private bool swapScenes = false;
        
    
    private void OnTriggerStay(Collider other)
    {
        if (other.tag.Equals("Hand"))
        {
            hand = other.GetComponent<HandPrescence>();

            if (hand.Grip() > .1f)
            {
                if (!swapScenes)
                {
                    Scene2();
                    swapScenes = true;
                }
            }
            
            
        }
        
    } // OnTriggerStay()

    private void Scene2()
    {
        room1.SetActive(false);
        room2.SetActive(true);
    }
    
    
} // class
