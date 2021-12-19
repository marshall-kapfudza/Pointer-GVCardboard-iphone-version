using UnityEngine;
using PCS;

public class NodeDetection : MonoBehaviour
{
    [field: SerializeField]
    public  NodeController Node { get; private set; }
    [field: SerializeField]
    public PCSConfig Conveyor { get; private set; }
    [field: SerializeField]
    public static int NodesOnConveyor { get; private set; }
    
    private void Start()
    {
        Conveyor = transform.parent.GetComponentInChildren<PCSConfig>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Node") return;
        NodesOnConveyor++;
        Node = other.gameObject.GetComponent<NodeController>();
        ActivateConveyor(ConveyorDirection.STOP);
    }

    private void OnTriggerExit()
    {
        Node = null;
    }
    public static void ResetActiveNodes()
    {
        NodesOnConveyor = 0;
    }
    public void ActivateConveyor(float direction)
    {
        Conveyor.SetSpeed(direction);
    }
}
