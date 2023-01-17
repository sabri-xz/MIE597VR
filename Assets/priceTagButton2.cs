using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class priceTagButton2 : MonoBehaviour
{
    public GameObject smthToDisable;
    public GameObject smthToEnable;
    public void updateTag()
    {
        smthToDisable.SetActive(false);
        smthToEnable.SetActive(true);
    }
}
