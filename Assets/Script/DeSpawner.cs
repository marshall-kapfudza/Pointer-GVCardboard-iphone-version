using UnityEngine;

public class DeSpawner : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        ObjectPool.Instance.DeSpawnObject(other.gameObject);
    }

    
}
