using UnityEngine.UI;
using UnityEngine;

public class UIMenu : MonoBehaviour
{
    private bool isMenuHidden = false;

    private Controller controller;
    private void Awake()
    {
        controller = new Controller();
        controller.Menu.PopUp.performed += ctx => MenuDisplay();
    }
    private void OnEnable()
    {
        controller.Menu.Enable();
    }
    private void OnDisable()
    {
        controller.Menu.Disable();
    }
    public void MenuDisplay()
    {
        isMenuHidden = !isMenuHidden;
        this.gameObject.SetActive(isMenuHidden);
    }
    public void MenuInsertNode()
    {
       
    }

    public void MenuDeleteNode()
    {

    }

    public void ExitMenu()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }


}
