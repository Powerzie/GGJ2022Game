using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveQuestFinalZone : MonoBehaviour
{
    public Animator reactionAnimator;
    public GameObject crystal;
    public List<GameObject> applesTriggers;
    public InCaveCrystalQuestZone InCaveCrystalQuestZoneSRC;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player"&& InCaveCrystalQuestZoneSRC.IsPlayerHaveCrystal())
        {
            Destroy(crystal);
            reactionAnimator.SetTrigger("React");

            for(int a= 0;a<applesTriggers.Count;a++)
            {
                applesTriggers[a].SetActive(true);  
            }

        }
    }
}
