using System.Collections.Generic;
using UnityEngine;


public class ConveyorHandler : MonoBehaviour
{
    public List<NodeDetection> ConveyorBelt { get; private set; }

    private void Awake()
    {
        ConveyorBelt = new List<NodeDetection>();
    }

    private void Start()
    {
        NodeDetection belt = null;
        foreach(Transform child in transform)
        {
            belt = child.GetComponentInChildren<NodeDetection>();
            if(belt != null)
                ConveyorBelt.Add(belt);
        }

        ChangeConveyorBeltState(ConveyorDirection.LEFT);

        
    }
    //Turns all the convoyer on and move nodes to right left or stop
    public void ChangeConveyorBeltState(float direction)
    {
        foreach(var belt in ConveyorBelt)
        {
            belt.ActivateConveyor(direction);
        }
    }

    //shift nodes right and insert the node at the currentNode;
    public void InsertNode()
    {

    }
    //remove node at current node and shift nodes to the left
    public void RemoveNode()
    {

    }
}
