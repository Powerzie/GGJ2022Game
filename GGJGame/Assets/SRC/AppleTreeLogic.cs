using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTreeLogic : MonoBehaviour
{

    public  GameObject hintText;
    public  PlayerMovement playerMovementScript;
    public  List<GameObject> dropObjects;

    private bool playerInTriger;
    private string buttonToPress;

    void Start()
    {
        buttonToPress = "f";

    }
    void Update()
    {
        if (playerInTriger && Input.GetKey(buttonToPress))
        {
         

            if (buttonToPress == "a")
                buttonToPress = "d";
            else
            {
                buttonToPress = "a";
                DrobObject();
                if (dropObjects.Count - 1 == 0)
                {
                    QuestDone();
                }
            }

            hintText.GetComponent<TextMesh>().text = buttonToPress;
        }

        if (playerInTriger && Input.GetKey("f"))
        {
            RunQuest();
        }
    }
    private void QuestDone()
    {
        playerMovementScript.EnablePlayerMovement();

        Destroy(hintText);
        Destroy(this);
    }
    private void RunQuest()
    {
        playerMovementScript.DisablePlayerMovement();
        hintText.GetComponent<TextMesh>().text = buttonToPress;
        buttonToPress = "a";
    }
    private void DrobObject()
    {
         dropObjects[dropObjects.Count-1].GetComponent<Rigidbody>().isKinematic = false;
        dropObjects.RemoveAt(dropObjects.Count-1); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player" && hintText)
        {
            playerInTriger = true;
            hintText.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && hintText)
        {
            hintText.SetActive(false);
            playerInTriger = false;
        }
    }
}
