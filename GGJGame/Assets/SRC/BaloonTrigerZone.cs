using System.Collections;
using System.Collections.Generic;
using UnityEngine;
enum BaloonTrigers { Show,Hide};
public class BaloonTrigerZone : MonoBehaviour
{
    public GameObject targetBaloon;
    private Animator targetAnimator;
    // Start is called before the first frame update
    void Start()
    {
        targetAnimator = targetBaloon.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        targetAnimator.SetTrigger("Show");
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            targetAnimator.SetTrigger("Hide");

      //  targetAnimator.SetTrigger((int)BaloonTrigers.Hide);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
