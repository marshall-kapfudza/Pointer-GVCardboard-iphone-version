using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using System;

public class ConveyorHandler : MonoBehaviour
{
    
    public List<NodeDetection> Belts { get; private set; }
    public bool isBeltOn { get; private set; }
    public int insert = 0;
    private Coroutine DropNodeCoroutine;
    Rigidbody NI_RigidBody;


    private void Awake()
    {
        Belts = new List<NodeDetection>();
    }

    private void Start()
    {
        isBeltOn = false;
        NodeDetection belt;
        foreach(Transform child in transform)
        {
            belt = child.GetComponentInChildren<NodeDetection>();
            if (belt != null)
                Belts.Add(belt);
        }

        ChangeConveyorBeltState(ConveyorDirection.LEFT);
        DropNodeCoroutine = StartCoroutine(DropNode());
        NI_RigidBody = null;

    }
    private void Update()
    {
        if (!isBeltOn) return;
        if(NodeDetection.NodesOnConveyor == ObjectPool.ActivePool)
        {
            ChangeConveyorBeltState(ConveyorDirection.STOP);
            isBeltOn = false;
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
        NodeDetection nodeDetection = Belts[0];
        Vector3 postionToSpawnNode = nodeDetection.transform.position;
        Quaternion rotationToSpawnNode = nodeDetection.transform.rotation;
        Vector3 offset = new Vector3(0, 3, 0);
        postionToSpawnNode = postionToSpawnNode + offset;
        var nodeToInsert = ObjectPool.Instance.SpawnFromPool("Node", postionToSpawnNode, rotationToSpawnNode);
        NodeDetection.ResetActiveNodes();
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

    //remove node at current node and shift nodes to the left
    public void RemoveNode()
    {

    }
}
