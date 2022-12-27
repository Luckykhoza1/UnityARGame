using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

//this script was an attempt to use the trigger button on the ML controller. It did work with this kind a script. However, using the OnCollider function was more useful and flexible for different objects.
public class ButtonScript : MonoBehaviour {

    public Transform objectToPickUp; // chosen game object to be picked up in the scene.
    public Transform picker; //the object that picks the objectedToPickUp. this was the controller.

    void Update() {
        if (MLInput.GetController(MLInput.Hand.Left).TriggerValue > 0.2f) //if the trigger button is pressed with a force more than 0.2f, move the objectToPickUp to the picker's position.
        {
            objectToPickUp.SetParent(picker);
            objectToPickUp.position = picker.position;
        }
    }
}
