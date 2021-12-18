using UnityEngine;

public class Node : MonoBehaviour
{
    [field: SerializeField]
    public GameObject Front { get; private set; }
    [field: SerializeField]
    public GameObject Back { get; private set; }
    public void Start()
    {
        Front =  transform.GetChild(0).gameObject;
        Back = transform.GetChild(1).gameObject;
    }
}
