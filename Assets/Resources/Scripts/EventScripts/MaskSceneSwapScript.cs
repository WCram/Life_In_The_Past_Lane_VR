using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskSceneSwapScript : MonoBehaviour
{

    public GameObject[] scenes;
    public GameObject[] masks;
    
    enum CURRENTSCENE { Main, Friend1, Friend2, Friend3 }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Mask"))
        {
            int scene = other.GetComponent<MaskScript>().scene;
            SwapScenes(scene);
            SwapMasks(scene);
        }
    } // OnTriggerEnter()

    private void SwapScenes(int scene)
    {
        DeactivateScenes();
        scenes[scene].SetActive(true);
    } // SwapScenes()

    private void DeactivateScenes()
    {
        for (int i = 0; i < scenes.Length; i++)
        {
            scenes[i].SetActive(false);
        }
    } // DeactivateScenes()
    
    private void SwapMasks(int scene)
    {
        DeactivateMasks();
        masks[scene].SetActive(true);
    } // SwapMasks()
    
    
    private void DeactivateMasks()
    {
        for (int i = 0; i < masks.Length; i++)
        {
            masks[i].SetActive(false);
        }
    } // DeactivateMasks()
    
} // class
