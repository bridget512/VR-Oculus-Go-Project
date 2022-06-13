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
        //this.transform.position = newTransform;

        // else set transform position back to original transform location
        this.transform.position = initialTransform;
    }

    public void Start()
    {
        // Stores the original transform position (global) of the object
        initialTransform = this.transform.position; 
    }

    public void Update()
    {
        // Required for grab and drag functionality
        if (isSelected == true)
        {// Changes default xrgrab behaviour to use distance from selected object
            this.transform.position = controller.transform.position + (controller.transform.forward * (distance)); // Andrew 
        }
        else
        {// Resets default xrgrab behaviour so default interactable behaviour is used
            this.transform.position = this.transform.position;
        }
    }

}
