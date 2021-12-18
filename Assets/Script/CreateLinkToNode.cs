using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLinkToNode : MonoBehaviour
{
    [SerializeField] GameObject CableStart;
    [SerializeField] GameObject CableEnd;
    [SerializeField] ConveyorHandler conveyor;

    //CableStatic NewCable;
    [SerializeField]
    private Node EndPoint;
    [SerializeField]
    private Node StartPoint;

    private void Update()
    {
        if (EndPoint == null && StartPoint == null) return;
        if (!conveyor._isBeltOn) return;
        //LinkCableToNode();
    }

    [ContextMenu("LinkCableToNode")]
    public void LinkCableToNode()
    {
        CableStart.transform.position = StartPoint.Front.transform.position;
        CableEnd.transform.position = EndPoint.Back.transform.position;
    }
}
