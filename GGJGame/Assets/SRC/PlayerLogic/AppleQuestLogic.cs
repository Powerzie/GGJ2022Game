using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleQuestLogic : MonoBehaviour
{
    public bool QuestIsEnded { get; set; } =false;
    private int countOfAppleToBring = 5;
    private int currentCountOfApples = 0;
    public GameObject floatCircle;
    private List<GameObject> floatingApples;
    private List<Vector3> appleOffset;
    private Vector3 lastOffset = new Vector3(-1f,-1f,0f);
    private float offsetStep =0.33f;
    private void Start()
    {
        floatingApples = new List<GameObject>();
        appleOffset = new List<Vector3>();
    }
    public void FixedUpdate()
    {
        if (floatingApples != null)
        {
            for (int a = 0; a < floatingApples.Count ; a++)
            {
                Vector3 floatPosition = Vector3.Lerp(floatingApples[a].transform.position, floatCircle.transform.position + appleOffset[a], 0.33f );
                floatingApples[a].transform.position = floatPosition;
            }
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Apple"&&!QuestIsEnded)
        {
            other.gameObject.transform.SetParent(floatCircle.transform);
            other.gameObject.transform.localScale =new Vector3(0.1f,0.1f,0.1f);
            floatingApples.Add(other.gameObject);

                appleOffset.Add(new Vector3(lastOffset.x += offsetStep, 0f, 0f));

            if (++currentCountOfApples ==countOfAppleToBring)
            EndAppleQuest();
        }
    }
    private void EndAppleQuest()
    {
        QuestIsEnded = true;
        Debug.Log("ENDED");
    }
    public bool IsQuestDone()
    {
        return QuestIsEnded;
    }
    public void DropAllApples()
    {
        if (floatingApples != null)
        {
            for (int a = 0; a < floatingApples.Count; a++)
            {
                floatingApples[a].GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX;
                floatingApples[a].GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ;
                floatingApples[a].transform.parent = null;
            }
        }
        floatingApples = null;
    }
    public bool IsPlayerBringApples()
    {
        return floatingApples==null;
    }
}
