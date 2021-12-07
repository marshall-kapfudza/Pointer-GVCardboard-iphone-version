using UnityEngine;

public class NodeSpawner : MonoBehaviour
{
    public GameObject nodePrefab;

    [ContextMenu("Create a New Node")]
    void CreateNewNode()
    {
        Instantiate(nodePrefab, transform.position, Quaternion.identity);
    }
}
