using UnityEngine;
using PCS;

public static class ConveyorDirection
{
    public const float STOP = 0f;
    public const float LEFT = 1f;
    public const float RIGHT = -1f;
}
public class NodeDetection : MonoBehaviour
{
    [field: SerializeField]
    public  GameObject Node { get; private set; }
    [field: SerializeField]
    public PCSConfig Conveyor { get; private set; }
    public static int ActiveNodes { get; private set; }
    private void Start()
    {
        ActiveNodes = 0;
        Conveyor = transform.parent.GetComponentInChildren<PCSConfig>();
    }
    private void OnTriggerEnter(Collider other)
    {
        ActiveNodes++;
        Node = other.gameObject;
        ActivateConveyor(ConveyorDirection.STOP);
    }

    private void OnTriggerExit()
    {
        Node = null;
    }
    public static void ResetActiveNodes()
    {
        ActiveNodes = 0;
    }
    public void ActivateConveyor(float direction)
    {
        Conveyor.SetSpeed(direction);
    }
}
