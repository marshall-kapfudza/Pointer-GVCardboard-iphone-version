using System.Collections;
using UnityEngine;

public class CoroutineSpawnNodeManager : MonoBehaviour
{
    public Coroutine NodeCoroutine { get; private set; }
    private GameObject _Node;
    private void Start()
    {
        _Node = null;
        NodeCoroutine = null;
    }
    private void OnTriggerExit(Collider other)
    {
        _Node = null;
    }
    public void SpawnNode(Vector3 transform, Quaternion rotation)
    {
        NodeCoroutine = StartCoroutine(GetNodeFromPool(transform, rotation));
    }
    private IEnumerator GetNodeFromPool(Vector3 transform, Quaternion rotation)
    {
        while (_Node == null)
        {
            yield return new WaitForSeconds(1f);
            _Node = ObjectPool.Instance.SpawnFromPool("Node", transform, rotation);
        }
    }

    
}
