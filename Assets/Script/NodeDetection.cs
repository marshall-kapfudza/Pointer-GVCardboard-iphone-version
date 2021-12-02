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
    
    public  GameObject Node { get; private set; }
    public PCSConfig Conveyor { get; private set; }

    private void Start()
    {
        Conveyor = transform.parent.GetComponentInChildren<PCSConfig>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Node = other.gameObject;
        ActivateConveyor(ConveyorDirection.STOP);
    }

    public void ActivateConveyor(float direction)
    {
        Conveyor.SetSpeed(direction);
    }

    private void OnTriggerExit()
    {
        Node = null;
    }
}
