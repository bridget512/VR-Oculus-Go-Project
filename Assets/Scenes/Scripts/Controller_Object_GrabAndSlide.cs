using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Controller_Object_GrabAndSlide : MonoBehaviour
{
    float distance = 0; // Andrew
    GameObject controller; // Andrew
    bool isSelected = false;

    Vector3 initialTransform;
    Vector3 newTransform;

    public void getCollidedTransform(Collider col)
    {
        newTransform = col.attachedRigidbody.transform.position;
    }

    public void SelectEntered(XRBaseInteractor args) 
    {
        controller = args.attachTransform.gameObject; // Andrew
        distance = Vector3.Distance(this.transform.position, args.attachTransform.position); // Andrew
        isSelected = true;
    }

    public void SelectExited(XRBaseInteractor args) 
    {
        isSelected = false;
        // if block returns correct, place object in new transform position

        // else set transform position back to original transform location
        this.transform.position = initialTransform;

        //this.transform.position = args.attachTransform.gameObject.transform.position;


    }

    public void Start()
    {
        initialTransform = this.transform.position; // Stores the original transform position (global) of the object
    }

    public void Update()
    {
        
        if (isSelected == true)
        {
            this.transform.position = controller.transform.position + (controller.transform.forward * (distance)); // Andrew 
        }
        else
        {
            this.transform.position = this.transform.position;
        }
    }

}
