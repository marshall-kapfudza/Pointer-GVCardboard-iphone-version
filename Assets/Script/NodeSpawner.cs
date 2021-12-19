using System.Collections;
using UnityEngine;
/*
 Abdoulaye 
 12/6/2021
 CSC 350H
 */
public class NodeSpawner : MonoBehaviour
{
    private CoroutineSpawnNodeManager _spawnManager;
    private ConveyorHandler _conveyorBelt;
    private bool _isSpawning;
    private NodeDetection _firstBelt;
    private Coroutine CableConnecter;
    void Start()
    {
        _conveyorBelt = GameObject.FindGameObjectWithTag("Convayor").GetComponent<ConveyorHandler>();
        _spawnManager = GetComponent<CoroutineSpawnNodeManager>();
        _firstBelt = _conveyorBelt.Belts[0];
        _isSpawning = false;
        CableConnecter = StartCoroutine(LinkNodes());
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!_isSpawning) return;
        _firstBelt.ActivateConveyor(ConveyorDirection.LEFT);
    }
    private void OnTriggerExit(Collider other)
    {
        if (!_isSpawning) return;
        _isSpawning = false;
    }

    public void CreateNewNode()
    {
        if (_isSpawning || NodeDetection.NodesOnConveyor != ObjectPool.ActivePool) return;
        NodeDetection.ResetActiveNodes();
        _conveyorBelt.ChangeConveyorBeltState(ConveyorDirection.LEFT);
        _spawnManager.SpawnNode(transform.position, transform.rotation);
        _isSpawning = true;

    }

    public void NodeConnect()
    {
        if (_conveyorBelt.Belts[1].Node == null) return;
        var OtherNode = _conveyorBelt.Belts[1].Node;
        _firstBelt.Node.ConnectCable(OtherNode);
    }

    private IEnumerator LinkNodes()
    {
        while (true)
        {
            yield return new WaitUntil(() => NodeDetection.NodesOnConveyor == ObjectPool.ActivePool);
            NodeConnect();
        }
    }

}