using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerInputHandler : MonoBehaviour
{
    [SerializeField]
    ConveyorHandler MoveConveyerBelts;
    NodeSpawner createANode;
    UIMenu Menu;
    private Controller controller;

    private void Awake()
    {
        controller = new Controller();

        controller.MainScene.ShowMenu.performed += ctx => Menu.MenuDisplay();
    }

    private void Start()
    {
        MoveConveyerBelts = GameObject.FindGameObjectWithTag("Convayor").GetComponent<ConveyorHandler>();
        createANode = GameObject.FindGameObjectWithTag("NodeSpawner").GetComponent<NodeSpawner>();
        Menu = GameObject.FindGameObjectWithTag("Menu").GetComponent<UIMenu>();
    }
    public void ExcuteInput(Gamepad Controller)
    {

        if (Controller.leftStick.left.isPressed)
        {
            if (MoveConveyerBelts.isBeltOn) return;
            NodeDetection.ResetActiveNodes();
            MoveConveyerBelts.ChangeConveyorBeltState(ConveyorDirection.LEFT);
        }
        if (Controller.leftStick.right.isPressed)
        {
            if (MoveConveyerBelts.isBeltOn) return;
            NodeDetection.ResetActiveNodes();
            MoveConveyerBelts.ChangeConveyorBeltState(ConveyorDirection.RIGHT);
        }
        if (Controller.dpad.left.isPressed)
        {
            createANode.CreateNewNode();
        }

        if (Controller.dpad.right.isPressed)
        {
            Menu.MenuDisplay();
        }

    }
}