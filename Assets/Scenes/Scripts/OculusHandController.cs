using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code from Module 7 (page 23)
public class OculusHandController : MonoBehaviour
{
    public GameObject leftHandController;
    public GameObject rightHandController;


    // Start is called before the first frame update
    void Start()
    {
        leftHandController.SetActive(false);
        rightHandController.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        OVRPlugin.Handedness handedness = OVRPlugin.GetDominantHand();
        if (handedness == OVRPlugin.Handedness.RightHanded) {
            if (!rightHandController.activeSelf) {
                leftHandController.SetActive(false);
                rightHandController.SetActive(true);
            }
        }
        else {
            if (!leftHandController.activeSelf) {
                leftHandController.SetActive(true);
                rightHandController.SetActive(false);
            }
        }
    }
}
