using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickToAble : MonoBehaviour
{
    public GameObject toEnable;
    public void enabling()
    {
        toEnable.SetActive(!toEnable.activeInHierarchy);
    }
}
