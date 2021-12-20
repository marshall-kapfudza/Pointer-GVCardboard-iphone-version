using System.Collections;
using UnityEngine;

public class CoroutineSpawnNodeManager : MonoBehaviour
{
    public Coroutine NodeCoroutine { get; private set; }
    private GameObject _node; 
    private void Start()
    {
        _node = null;
        NodeCoroutine = null;
    }
    private void OnTriggerExit(Collider other)
    {
        StopCoroutine(NodeCoroutine);
        _node = null;
    }
    public void SpawnNode(Vector3 transform, Quaternion rotation)
    {
        if (_node != null) return;
        NodeCoroutine = StartCoroutine(GetNodeFromPool(transform, rotation));
    }
    private IEnumerator GetNodeFromPool(Vector3 transform, Quaternion rotation)
    {
        yield return new WaitForSeconds(1f);
        _node = ObjectPool.Instance.SpawnFromPool("Node", transform, rotation);
        yield return new WaitUntil(() => NodeDetection.NodesOnConveyor == ObjectPool.ActivePool);
        ConveyorHandler.Instance.ResetCurrentPointer();
    }

    
}
