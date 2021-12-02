using System.Collections.Generic;
using UnityEngine;


public class ConveyorHandler : MonoBehaviour
{


    [field: SerializeField]
    public List<NodeDetection> Belts { get; private set; }

    private void Awake()
    {
        Belts = new List<NodeDetection>();
    }

    private void Start()
    {
        NodeDetection belt = null;
        foreach(Transform child in transform)
        {
            belt = child.GetComponentInChildren<NodeDetection>();
            if(belt != null)
                Belts.Add(belt);
        }

        

        
    }
    //Turns all the convoyer on and move nodes to right left or stop
    public void ChangeConveyorBeltState(float direction)
    {
        foreach(var belt in Belts)
        {
            belt.ActivateConveyor(direction);
        }
    }
    [ContextMenu("Turn On Conveyor")]
    public void turnon()
    {
        ChangeConveyorBeltState(ConveyorDirection.LEFT);
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
