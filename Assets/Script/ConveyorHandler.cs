using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using System;

public class ConveyorHandler : MonoBehaviour
{
    public static ConveyorHandler Instance;

    private NodeController currentPointer;
    private Coroutine DropNodeCoroutine;
    private Rigidbody NI_RigidBody;
    public List<NodeTracker> Belts { get; private set; }
    public bool isBeltOn { get; private set; }
    


    private void Awake()
    {
        Instance = this;
        Belts = new List<NodeTracker>();
    }

    private void Start()
    {
        
        isBeltOn = false;
        NodeTracker belt;
        foreach(Transform child in transform)
        {
            belt = child.GetComponentInChildren<NodeTracker>();
            if (belt != null)
                Belts.Add(belt);
        }

        ChangeConveyorBeltState(ConveyorDirection.LEFT);
        DropNodeCoroutine = StartCoroutine(DropNode());
        NI_RigidBody = null;
        currentPointer = null;

    }
    private void Update()
    {
        
        if (!isBeltOn) return;
        if(NodeTracker.NodesOnConveyor == ObjectPool.ActivePool)
        {
            ChangeConveyorBeltState(ConveyorDirection.STOP);
            isBeltOn = false;
        }

    }

    public bool Empty()
    {
        bool isConveyorBeltEmpty = true;

        foreach(NodeTracker belt in Belts)
        {
            if (belt.Node != null)
                return !isConveyorBeltEmpty;
        }
        return isConveyorBeltEmpty;
    }

    //Turns all the convoyer on and move nodes to right left or stop
    public void ChangeConveyorBeltState(float direction)
    {
        isBeltOn = true;
        foreach(var belt in Belts)
        {
            belt.ActivateConveyor(direction);
        }
    }
   
    [ContextMenu("Insert Node")]
    //shift nodes right and insert the node at the currentNode;
    public void InsertNode()
    {
        
        if (Belts[0].Node == null) return;
        NodeTracker nodeDetection = Belts[0];
        Vector3 postionToSpawnNode = nodeDetection.transform.position;
        Quaternion rotationToSpawnNode = nodeDetection.transform.rotation;
        Vector3 offset = new Vector3(0, 3, 0);
        postionToSpawnNode = postionToSpawnNode + offset;
        var nodeToInsert = ObjectPool.Instance.SpawnFromPool("Node", postionToSpawnNode, rotationToSpawnNode);
        NodeTracker.ResetActiveNodes();
        ChangeConveyorBeltState(ConveyorDirection.LEFT);
        NI_RigidBody = nodeToInsert.GetComponent<Rigidbody>();
        NI_RigidBody.useGravity = false;

    }

    private IEnumerator DropNode()
    {
        while (true)
        {
            yield return new WaitUntil(() => NI_RigidBody != null);
            yield return new WaitForSeconds(2f);
            NI_RigidBody.useGravity = true;
            NI_RigidBody = null;  
        }
    }

    public void HighlightRightNode()
    {
        
    }

    public void HighlightLeftNode()
    {
        
    }

    public void SelectNode()
    {
        if(currentPointer != null)
        currentPointer.OnSelect();
    }

    public int FindCurrent()
    {
        return Belts.FindIndex(node => node == currentPointer);
    }
    public void ResetCurrentPointer()
    {
        if (currentPointer != null)
        {
            if(currentPointer.IsSelected)
                SelectNode();
        }
        currentPointer = Belts[0].Node;
    }
    //remove node at current node and shift nodes to the left
    public void RemoveNode()
    {

    }
}
