using UnityEngine.EventSystems;
using UnityEngine;

public class UIMenu : MonoBehaviour
{
    public GameObject menuFirstButton;
    private bool isMenuHidden = false;

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

    public void MoveUpDown()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(menuFirstButton);

    }

}
