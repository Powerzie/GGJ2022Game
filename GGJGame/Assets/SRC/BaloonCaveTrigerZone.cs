using System.Collections;
using System.Collections.Generic;
using UnityEngine;
enum BaloonTrigers { Show, Hide };
public class BaloonCaveTrigerZone : MonoBehaviour
{
    public AppleQuestLogic AppleQuestLogicSRC;
    public GameObject targetBaloon;
    public Animator reactionAnimator;
    private Animator targetAnimator;
    void Start()
    {
        targetAnimator = targetBaloon.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            targetAnimator.SetTrigger(BaloonTrigers.Show.ToString());

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            targetAnimator.SetTrigger(BaloonTrigers.Hide.ToString());
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
