using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script to attach packages to the attach point. this script was attached to the sphere that was used to pick up the packages.

public class AttachPackage : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Package")) {
            collision.gameObject.transform.SetParent(transform);
            collision.gameObject.GetComponent<Rigidbody>().useGravity = false; //disable gravity component of package.
        }
    }
}
