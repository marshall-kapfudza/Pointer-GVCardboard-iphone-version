using UnityEngine;
using PCS;
public class NodeDetection : MonoBehaviour
{
    
    public  GameObject Node { get; private set; }
    private PCSConfig Conveyor;

    private void Start()
    {
        Conveyor = transform.parent.gameObject.GetComponentInChildren<PCSConfig>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Node = other.gameObject;
        Conveyor.SetSpeed(0);
    }
    private void OnTriggerExit()
    {
        Node = null;
    }
}
