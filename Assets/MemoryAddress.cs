using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MemoryAddress : MonoBehaviour
{
    void Start()
    {
        var thisAddress = GetComponent<TMPro.TextMeshProUGUI>();
        thisAddress.SetText(Random.Range(0,1000).ToString());
    }
}
