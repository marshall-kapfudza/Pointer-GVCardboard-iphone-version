using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewNode : MonoBehaviour
{
    public GameObject pointer;

    [ContextMenu("turn pointer")]
    public void demoturnon()
    {
        pointer.SetActive(true);
    }


}
