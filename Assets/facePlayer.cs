using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class facePlayer : MonoBehaviour
{
    public GameObject item;
    public Transform head;

    // Update is called once per frame
    void Update()
    {
        item.transform.LookAt(new Vector3(head.position.x, item.transform.position.y, head.position.z));
    }
}
