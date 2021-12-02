using System.Collections.Generic;
using UnityEngine;


public class ConveyorHandler : MonoBehaviour
{


    [field: SerializeField]
    public List<NodeDetection> Belts { get; private set; }
    private bool isBeltOn;
    private void Awake()
    {
        Belts = new List<NodeDetection>();
    }

    private void Start()
    {
        isBeltOn = false;
        NodeDetection belt = null;
        foreach(Transform child in transform)
        {
            belt = child.GetComponentInChildren<NodeDetection>();
            if(belt != null)
                Belts.Add(belt);
        }

        ChangeConveyorBeltState(ConveyorDirection.LEFT);

    }
    private void Update()
    {
        if (!isBeltOn) return;
        if(NodeDetection.ActiveNodes == 2)
        {
            ChangeConveyorBeltState(ConveyorDirection.STOP);
        }
    }
    //Turns all the convoyer on and move nodes to right left or stop
    public void ChangeConveyorBeltState(float direction)
    {
        isBeltOn = true;
        NodeDetection.ResetActiveNodes();
        foreach(var belt in Belts)
        {
            belt.ActivateConveyor(direction);
        }
    }
    [ContextMenu("Turn On Conveyor to left")]
    public void Demoturnleft()
    {
        ChangeConveyorBeltState(ConveyorDirection.LEFT);
    }
    [ContextMenu("Turn On Conveyor to right")]
    public void Demoturnright()
    {
        ChangeConveyorBeltState(ConveyorDirection.RIGHT);
    }
    [ContextMenu("Stop Conveyor")]
    public void DemoStop()
    {
        ChangeConveyorBeltState(ConveyorDirection.STOP);
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
