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
    private ConveyorHandler _ConveyorBelt;
    private bool _isSpawning;
    void Start()
    {
        _ConveyorBelt = GameObject.FindGameObjectWithTag("Convayor").GetComponent<ConveyorHandler>();
        _spawnManager = GetComponent<CoroutineSpawnNodeManager>();
        _isSpawning = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        _ConveyorBelt.Belts[0].ActivateConveyor(ConveyorDirection.LEFT);
    }
    private void OnTriggerExit(Collider other)
    {
        StopCoroutine(_spawnManager.NodeCoroutine);
        _isSpawning = false;
    }

    public void CreateNewNode()
    {
        if (_isSpawning) return;
        _ConveyorBelt.ChangeConveyorBeltState(ConveyorDirection.LEFT);
        _spawnManager.SpawnNode(transform.position, transform.rotation);
        _isSpawning = true;
    }


}