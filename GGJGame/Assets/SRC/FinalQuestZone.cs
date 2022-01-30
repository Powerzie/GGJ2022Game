using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalQuestZone : MonoBehaviour
{
  public Animator crystalAnimator;
  public Animator cameraAnimator;
  public AppleQuestLogic AppleQuestLogicSRC;

    public void RunCameraAnimation()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && AppleQuestLogicSRC.IsQuestDone() && AppleQuestLogicSRC.IsPlayerBringApples())
        {
            crystalAnimator.SetTrigger("CrystalShine");
            cameraAnimator.SetTrigger("CameraFly");
        }
    }
}
