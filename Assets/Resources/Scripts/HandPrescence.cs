using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class HandPrescence : MonoBehaviour
{


    public InputDeviceCharacteristics inputDevice;

    private InputDevice device;
    private List<InputDevice> devices;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(inputDevice, devices);
        if (devices.Count > 0)
        {
            device = devices[0];
            anim = GetComponent<Animator>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (anim != null)
        {
            UpdateHandAnimation();
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("test");
            Application.Quit();
        }
        
        
    }

    public float Grip()
    {
        return (device.TryGetFeatureValue(CommonUsages.grip, out float gripValue)) ? gripValue : 0f;
    } // Grip
    
    void UpdateHandAnimation()
    {
        if (device.TryGetFeatureValue(CommonUsages.trigger, out float pinchValue))
        {
            anim.SetFloat("Pinch", pinchValue);
        }
        else
        {
            anim.SetFloat("Pinch", 0f);
        }

        if (device.TryGetFeatureValue(CommonUsages.grip, out float gripValue))
        {
            anim.SetFloat("Grip", gripValue);
        }
        else
        {
            anim.SetFloat("Grip", 0f);
        }
    } // UpdateHandAnimat()
    
} // class
