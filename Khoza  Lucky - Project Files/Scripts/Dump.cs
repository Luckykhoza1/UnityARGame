using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

//when a package collides with the trashbin, remove its meshrenderer, and make its rigidbody kinematic.
//attach to each package.
public class Dump : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Dump")) {
            Remove();
        }
    }

    void Remove() {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
    }   
}
