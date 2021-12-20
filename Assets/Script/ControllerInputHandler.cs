using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerInputHandler : MonoBehaviour
{
    [SerializeField]
    ConveyorHandler _conveyerBelts;
    NodeSpawner _nodeSpawner;
    Controller controller;
    [SerializeField]
    UIMenu menu;

    //Main Scene Controller
    InputAction selectNode;
    InputAction enableMenu;
    InputAction nextPointer;
    InputAction backPointer;

    //Menu Scene Controller
    InputAction disableMenu;


    private void Awake()
    {
        controller = new Controller();
        selectNode = controller.MainScene.SelectPointer;
        enableMenu = controller.MainScene.EnableMenu;
        nextPointer = controller.MainScene.NextPointer;
        backPointer = controller.MainScene.BackPointer;
        disableMenu = controller.Menu.DisableMenu;

        enableMenu.performed += ctx => ShowMenu();
        selectNode.performed += ctx => _conveyerBelts.SelectNode();
        nextPointer.performed += ctx => _conveyerBelts.HighlightLeftNode();
        backPointer.performed += ctx => _conveyerBelts.HighlightRightNode();

        controller.MainScene.TestInsert.performed += ctx => _nodeSpawner.CreateNewNode();
        disableMenu.performed += ctx => DisableMenu();
        
    }
    private void Start()
    {
        _conveyerBelts = GameObject.FindGameObjectWithTag("Convayor").GetComponent<ConveyorHandler>();
        _nodeSpawner = GameObject.FindGameObjectWithTag("NodeSpawner").GetComponent<NodeSpawner>();
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
}