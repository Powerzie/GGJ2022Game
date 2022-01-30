using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndZoneAppleQuest : MonoBehaviour
{
   public AppleQuestLogic playerAppleQuestLogic;
    public List<Animator> foxesAnimator;
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag=="Player"&& playerAppleQuestLogic.IsQuestDone())
        {
            playerAppleQuestLogic.DropAllApples();
            for(int a =0;a< foxesAnimator.Count;a++)
            {
                foxesAnimator[a].SetTrigger("Run" + (1+a).ToString());
            }
        }
    }
}
