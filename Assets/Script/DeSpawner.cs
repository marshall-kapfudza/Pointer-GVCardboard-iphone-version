using UnityEngine;

public class DeSpawner : MonoBehaviour
{
    [SerializeField]
    private NodeTracker ConveyorEdge;
    private void OnTriggerExit(Collider other)
    {
        ObjectPool.Instance.DespawnObject(other.gameObject);
    }

    
}
