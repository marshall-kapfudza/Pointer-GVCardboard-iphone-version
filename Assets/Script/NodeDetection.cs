using UnityEngine;
using PCS;

public class NodeDetection : MonoBehaviour
{
    [field: SerializeField]
    public  GameObject Node { get; private set; }
    [field: SerializeField]
    public PCSConfig Conveyor { get; private set; }
    [field: SerializeField]
    public static int NodesOnConveyor { get; private set; }
    
    private void Start()
    {
        NodesOnConveyor = 0;
        Conveyor = transform.parent.GetComponentInChildren<PCSConfig>();
    }
    private void OnTriggerEnter(Collider other)
    {
        NodesOnConveyor++;
        Node = other.gameObject;
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
