using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//script for counting how many packages are dumped.
public class DumpScore : MonoBehaviour
{
    int Score = 0;
    public TMP_Text DumpedAmount;
    //public InputField inputField;


    // Start is called before the first frame update
    void OnCollisionEnter( Collision collision) {
        if (collision.gameObject.CompareTag("Dump")) {
            Score++;
            DumpedAmount.text = "Dumped Packages: " + Score;
            }

        //if the player dumps 3 or more packages, invoke TryAgrain which restart the scene.
        else if (Score>=3) {
            Invoke(nameof(TryAgain), 2.0f);
        }

        }
    
    //restarts the current scene.
    void TryAgain(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
