using System.Collections.Generic;
using UnityEngine;
using PCS;
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
    //Turns all the convoyer on and move nodes to right
    public void ShiftConveyorRight()
    {
        foreach(var belt in ConveyorBelt)
        {
            belt.SetSpeed(1);
        }
    }
    //Turns all the convoyer on and move nodes to left
    public void ShiftConveyorLeft()
    {
        foreach (var belt in ConveyorBelt)
        {
            belt.SetSpeed(-1);
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
