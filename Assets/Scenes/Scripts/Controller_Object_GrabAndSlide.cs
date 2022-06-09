using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Controller_Object_GrabAndSlide : MonoBehaviour
{
    float distance = 0; // Andrew
    GameObject controller; // Andrew
    int isSelected = 0;

    Vector3 initialTransform;

    public void SelectEntered(XRBaseInteractor args) {

        initialTransform = transform.position;
        controller = args.attachTransform.gameObject; // Andrew
        distance = Vector3.Distance(this.transform.position, args.attachTransform.position); // Andrew
        isSelected = 1;
    }

    public void SelectExited(XRBaseInteractor args) {
        isSelected = 0;
        this.transform.position = initialTransform;
    }

    public void Update()
    {
        if (isSelected == 1)
        {
            this.transform.position = controller.transform.position + (controller.transform.forward * distance); // Andrew 
        }
        else
        {
            this.transform.position = this.transform.position;
        }
        
    }
}
