using UnityEngine;
using UnityEngine.EventSystems;

using UnityEngine.UI;

public class UIMenu : MonoBehaviour
{
    //public int currentSelection = 0;
    //public GameObject[] buttons;
    public GameObject menuFirstButton;
    private bool isMenuHidden = false;

    public Selectable currentSelection;
    private void Awake()
    {
        currentSelection = menuFirstButton.GetComponent<Selectable>();
        
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

    public void Move()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(menuFirstButton);
    }

    public void MoveDown()
    {
        currentSelection = currentSelection.FindSelectableOnDown();
        currentSelection.Select();
        
    }
    
    
}
