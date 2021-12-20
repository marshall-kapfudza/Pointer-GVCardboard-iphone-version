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
        controller.MainScene.EnableMenu.performed += ctx => ShowMenu();
        controller.MainScene.InsertNewNode.performed += ctx => createANode.CreateNewNode();
        controller.Menu.DisableMenu.performed += ctx => DisableMenu();
        controller.Menu.DisableMenu.performed += ctx => menu.MoveUpDown();
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
        controller.Menu.Enable();
        
    }

    public void DisableMenu()
    {
        menu.MenuDisplay();
        controller.Menu.Disable();
        controller.MainScene.Enable();
    }
    private void OnEnable()
    {
        controller.MainScene.Enable();
        controller.Menu.Disable();
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