using UnityEngine;
/*
 Abdoulaye 
 12/6/2021
 CSC 350H
 */
public class NodeSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject nodePrefab;
    private CoroutineSpawnNodeManager _spawnManager;
    private ConveyorHandler _conveyorBelt;
    private bool _isSpawning;
    private NodeDetection _firstBelt;
    void Start()
    {
        _conveyorBelt = GameObject.FindGameObjectWithTag("Convayor").GetComponent<ConveyorHandler>();
        _spawnManager = GetComponent<CoroutineSpawnNodeManager>();
        _firstBelt = _conveyorBelt.Belts[0];
        _isSpawning = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        
        _firstBelt.ActivateConveyor(ConveyorDirection.LEFT);
    }
    private void OnTriggerExit(Collider other)
    {
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


}