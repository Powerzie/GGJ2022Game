using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InCaveCrystalQuestZone : MonoBehaviour
{
    private bool playerInTriger = false;
    private bool isTaked = false;
    string buttonToPress = "f";
    public GameObject hintText;
    public GameObject floatCircle;
    public GameObject crystal;

    void Start()
    {
        
    }
    void Update()
    {
        if (playerInTriger && Input.GetKey(buttonToPress))
        {
            crystal.transform.SetParent(floatCircle.transform);
            crystal.gameObject.transform.localScale = new Vector3(10f, 10f, 10f);
            isTaked = true;
           
        }
        if(isTaked&& crystal)
        {
            Vector3 floatPosition = Vector3.Lerp(crystal.transform.position, floatCircle.transform.position+ new Vector3(0f,-1f,0f) ,1.0f);
            crystal.transform.position = floatPosition;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && hintText)
        {
            playerInTriger = true;
            hintText.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && hintText)
        {
            playerInTriger = false;
            hintText.SetActive(false);
        }
    }
    public bool IsPlayerHaveCrystal()
    {
        return isTaked;
    }
}
