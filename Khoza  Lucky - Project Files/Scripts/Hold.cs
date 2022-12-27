using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is for when the table for saving packages collides with a package. This script is attached to the table.
public class Hold : MonoBehaviour
{
    
    void OnCollisionEnter(Collision collision) {
        
        if (collision.gameObject.CompareTag("Package")) {
            //makes the table the parent of the package's transform.
            collision.gameObject.transform.SetParent(transform);
            //enables gravity so on the package so that it drops on the table
            collision.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
