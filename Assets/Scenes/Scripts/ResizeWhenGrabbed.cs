using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ResizeWhenGrabbed : MonoBehaviour {

    // Before Grab Scale (scene scale)
    Vector3 startScale; 
    // New scale when grabbed
    Vector3 grabScale = new Vector3(0.2f, 0.2f, 0.2f); 

    public void SelectEntered(XRBaseInteractor args) {
        startScale = transform.localScale;
        transform.localScale = grabScale;
    }

    public void SelectExited(XRBaseInteractor args) {
        transform.localScale = startScale;
    }

}
