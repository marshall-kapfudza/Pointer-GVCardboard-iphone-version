using UnityEngine;

public class DeSpawner : MonoBehaviour
{
    [SerializeField]
    private NodeDetection ConveyorEdge;
    private void OnTriggerExit(Collider other)
    {
        ObjectPool.Instance.DeSpawnObject(other.gameObject);
    }

    
}
