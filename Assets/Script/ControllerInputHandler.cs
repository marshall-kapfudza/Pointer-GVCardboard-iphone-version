using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerInputHandler : MonoBehaviour
{
    [SerializeField]
    ConveyorHandler MoveConveyerBelts;
    NodeSpawner createANode;
    Controller controller;
    [SerializeField]
    UIMenu menu;

    private void Awake()
    {
        controller = new Controller();
        controller.MainScene.ShowMenu.performed += ctx => ShowMenu();
        controller.MainScene.InsertNewNode.performed += ctx => createANode.CreateNewNode();
    }
    private void Start()
    {
        MoveConveyerBelts = GameObject.FindGameObjectWithTag("Convayor").GetComponent<ConveyorHandler>();
        createANode = GameObject.FindGameObjectWithTag("NodeSpawner").GetComponent<NodeSpawner>();
    }
       
    public void ShowMenu()
    {
        menu.MenuDisplay();
        controller.MainScene.Disable();
    }
    private void OnEnable()
    {
        controller.MainScene.Enable();
    }
    private void OnDisable()
    {
        controller.MainScene.Disable();
    }




    /*public void ExcuteInput(Gamepad Controller)
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

    }*/
}