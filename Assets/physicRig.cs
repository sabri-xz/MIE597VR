using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class physicRig : MonoBehaviour
{
    public Transform playerHead;
    public CapsuleCollider bodyCollider;

    public float heightMin = 0.5f;
    public float heightMax = 2;

    // Update is called once per frame
    void fixedUpdate()
    {
        bodyCollider.height = Mathf.Clamp(playerHead.localPosition.y, heightMin, heightMax);
        bodyCollider.center = new Vector3(playerHead.localPosition.x, bodyCollider.height/2, playerHead.localPosition.z);
    }
}
