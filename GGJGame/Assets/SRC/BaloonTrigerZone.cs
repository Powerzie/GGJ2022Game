using System.Collections;
using System.Collections.Generic;
using UnityEngine;
enum BaloonTrigers { Show ,Hide};
public class BaloonTrigerZone : MonoBehaviour
{
    public AppleQuestLogic AppleQuestLogicSRC;
    public GameObject targetBaloon;
    public Animator reactionAnimator;
    private Animator targetAnimator;
    // Start is called before the first frame update
    void Start()
    {
        targetAnimator = targetBaloon.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            if (AppleQuestLogicSRC.IsQuestDone())
            {
                reactionAnimator.SetTrigger("AppleWinned");
            }
            reactionAnimator.SetTrigger("React");
            targetAnimator.SetTrigger(BaloonTrigers.Show.ToString());
         
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            reactionAnimator.SetTrigger("Idle");
            targetAnimator.SetTrigger(BaloonTrigers.Hide.ToString());
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
