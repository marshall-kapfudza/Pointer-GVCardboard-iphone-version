using UnityEngine;

public class ConveyorHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Belts;
    private int currentNode;
    public int CurrentNode 
    { 
        get { return currentNode; } 
        set 
        {
            if (value >= 0 && value <= 5)
                currentNode = value;
        } 
    }
    
    //Turns all the convoyer on and move nodes to right
    public void ShiftConveyorRight()
    {

    }
    //Turns all the convoyer on and move nodes to left
    public void ShiftConveyorLeft()
    {

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
