using System.Collections;
using UnityEngine;

public class CoroutineSpawnNodeManager : MonoBehaviour
{
    public Coroutine NodeCoroutine { get; set; }
    private void Start()
    {
        NodeCoroutine = null;
    }
    public void SpawnNode(Vector3 transform, Quaternion rotation)
    {
        NodeCoroutine = StartCoroutine(GetNodeFromPool(transform, rotation));
    }
    private IEnumerator GetNodeFromPool(Vector3 transform, Quaternion rotation)
    {
        bool spawning = true;
        while (spawning)
        {
            yield return new WaitForSeconds(1f);
            ObjectPool.Instance.SpawnFromPool("Node", transform, rotation).GetComponent<Node>();
            spawning = false;
        }
    }

    
}
