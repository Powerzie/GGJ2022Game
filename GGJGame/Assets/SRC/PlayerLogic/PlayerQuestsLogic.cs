using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerQuestsLogic : MonoBehaviour
{

    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}

public class AppleQuestLogic : MonoBehaviour
{
    public bool QuestIsEnded { get; set; } =false;
    public int countOfAppleToBring = 10;
    private int currentCountOfApples = 0;
    private void OnCollisionEnter(Collider other)
    {
        if(other.tag=="Apple"&&!QuestIsEnded)
        {
            Destroy(other.gameObject);
            if ( currentCountOfApples++ ==countOfAppleToBring)
            EndAppleQuest();
        }
    }

    private void EndAppleQuest()
    {
        QuestIsEnded = true;
    }
}

