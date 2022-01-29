using UnityEngine;

public class AppleQuestLogic : MonoBehaviour
{
    public bool QuestIsEnded { get; set; } =false;
    public int countOfAppleToBring = 10;
    private int currentCountOfApples = 0;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Apple"&&!QuestIsEnded)
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

