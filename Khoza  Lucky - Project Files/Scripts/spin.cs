using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script that was going to spin an package continously.
public class spin : MonoBehaviour
{
    public float spinSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(0, spinSpeed * Time.deltaTime, 0) ;
    }
}
