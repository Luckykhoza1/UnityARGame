using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

//script to keep count of how many packages were saved.
//each time there was a collision, the count would increase.
public class SavedScore : MonoBehaviour
{
    int Score = 0;
    public TMP_Text SavedAmount;
    
    // Start is called before the first frame update
    void OnCollisionEnter( Collision collision) {
        if (collision.gameObject.CompareTag("HoldPlace")) {
            Score++;
            SavedAmount.text = "Saved Packages: " + Score;
        }
    }
}
