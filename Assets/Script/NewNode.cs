using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewNode : MonoBehaviour
{
    public GameObject pointer;

    [ContextMenu("Turn Left Pointer")]
    public void demoturnon()
    {
        pointer.SetActive(true);
    }
}
