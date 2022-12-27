using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

//scripting help was received from Magic Leap through this link: https://ml1-developer.magicleap.com/en-us/learn/guides/unity-overview
//this script if for rendering a beam/ray from the ML controller to the scene.
//when the ray hits a object, we could then press the buttons on the controller and certain actions would happen.
//with this script, the beam was shot from the controller. But the buttons on the controller didn't work with the beam.
public class DynamicBeam : MonoBehaviour
{
    private MLInput.Controller controller;
    private LineRenderer beamLine;
    public Color startColor;
    public Color endColor;
    // Start is called before the first frame update
    void Start()
    {
        controller = MLInput.GetController(MLInput.Hand.Left);
        beamLine = GetComponent<LineRenderer>();
        beamLine.startColor = startColor;
        beamLine.endColor = endColor;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = controller.Position;
        transform.rotation = controller.Orientation;

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            beamLine.useWorldSpace = true;
            beamLine.SetPosition(0, transform.position);
            beamLine.SetPosition(1, hit.point);
        }
        else
        {
            beamLine.useWorldSpace = true;
            beamLine.SetPosition(0, transform.position);
            beamLine.SetPosition(1, transform.forward * 5);
        }
    }
}
