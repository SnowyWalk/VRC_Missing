
using TMPro;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class ExampleButton : UdonSharpBehaviour
{
    public GameObject anotherObj;


    public TextMeshProUGUI subtitle;


    float timer = 0.0f;


    public override void Interact()
    {
        subtitle.text = "What is going on?";
        subtitle.gameObject.SetActive(true);
    }



    private void Update()
    {
        // play in 60FPS -> Time.deltaTime will be 0.016 sec

        if (subtitle.gameObject.activeSelf == false) // if inactivated
        {
            timer = 0.0f; // reset
        }
        else 
        {
            timer += Time.deltaTime; // accumulate

            if (timer > 3.0f) // over 3 second
            {
                // deactivate subtitle
                subtitle.gameObject.SetActive (false);
            }
        }
        
    }

}
