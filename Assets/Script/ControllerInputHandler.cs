using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class ControllerInputHandler : MonoBehaviour
{
    [SerializeField]
    ConveyorHandler MoveConveyerBelts;
    NodeSpawner createANode;

    private void Start()
    {
        MoveConveyerBelts = GameObject.FindGameObjectWithTag("Convayor").GetComponent<ConveyorHandler>();
        createANode = GameObject.FindGameObjectWithTag("NodeSpawner").GetComponent<NodeSpawner>();
    }
    public void ExcuteInput(Gamepad Controller)
    {

        if (Controller.leftStick.left.isPressed)
        {
            MoveConveyerBelts.ChangeConveyorBeltState(ConveyorDirection.LEFT);
        }
        if (Controller.leftStick.right.isPressed)
        {
            MoveConveyerBelts.ChangeConveyorBeltState(ConveyorDirection.RIGHT);
        }
        if (Controller.dpad.left.isPressed)
        {
            createANode.CreateNewNode();
        }

    }

}