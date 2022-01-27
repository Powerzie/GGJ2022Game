using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerFollow : MonoBehaviour
{
   public Transform targetTransform;
   public Vector3 cameraOffset;
    public float followSpeed=2.0f;

    private void Start()
    {
    }
    void Update()
    {
            transform.position = Vector3.Lerp( transform.position, targetTransform.position + cameraOffset, followSpeed * Time.deltaTime);
    }
}
