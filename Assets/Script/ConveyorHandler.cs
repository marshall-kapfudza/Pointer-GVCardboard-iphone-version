using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;


public class ConveyorHandler : MonoBehaviour
{
    public List<NodeDetection> Belts { get; private set; }
    public bool _isBeltOn { get; private set; }
    private void Awake()
    {
        Belts = new List<NodeDetection>();
    }

    private void Start()
    {
        _isBeltOn = false;
        NodeDetection belt;
        foreach(Transform child in transform)
        {
            belt = child.GetComponentInChildren<NodeDetection>();
            if (belt != null)
                Belts.Add(belt);
        }

        ChangeConveyorBeltState(ConveyorDirection.LEFT);

    }
    private void Update()
    {
        if (!_isBeltOn) return;
        if(NodeDetection.NodesOnConveyor == ObjectPool.ActivePool)
        {
            ChangeConveyorBeltState(ConveyorDirection.STOP);
        }
    }

    public bool Empty()
    {
        bool isConveyorBeltEmpty = true;

        foreach(NodeDetection belt in Belts)
        {
            if (belt.Node != null)
                return !isConveyorBeltEmpty;
        }
        return isConveyorBeltEmpty;
    }

    //Turns all the convoyer on and move nodes to right left or stop
    public void ChangeConveyorBeltState(float direction)
    {
        _isBeltOn = true;
        foreach(var belt in Belts)
        {
            belt.ActivateConveyor(direction);
        }
    }
   
    [ContextMenu("Insert Node")]
    //shift nodes right and insert the node at the currentNode;
    public void InsertNode()
    {

    }

    //remove node at current node and shift nodes to the left
    public void RemoveNode()
    {

    }
}
