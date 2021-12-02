using System.Collections.Generic;
using UnityEngine;
using PCS;

public static class ConveyorSpeed
{
    const float STOP = 0f;
    const float LEFT = 1;
    const float RIGHT = -1;
}
public class ConveyorHandler : MonoBehaviour
{
    private List<PCSConfig> ConveyorBelt;

    private void Awake()
    {
        ConveyorBelt = new List<PCSConfig>();
    }

    private void Start()
    {
        PCSConfig belt = null;
        foreach(Transform child in transform)
        {
            belt = child.GetComponentInChildren<PCSConfig>();
            if(belt != null)
                ConveyorBelt.Add(belt);
        }
    }
    //Turns all the convoyer on and move nodes to right left or stop
    public void ChangeConveyorBeltState(float direction)
    {
        foreach(var belt in ConveyorBelt)
        {
            belt.SetSpeed(direction);
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
