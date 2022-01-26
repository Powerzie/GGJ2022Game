using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerFollow : MonoBehaviour
{
   public Transform targetTransform;
   public Vector3 cameraOffset;

    private void Start()
    {
    }
    void Update()
    {
            transform.position = Vector3.Lerp( transform.position, targetTransform.position + cameraOffset, 2f*Time.deltaTime);
    }
}
