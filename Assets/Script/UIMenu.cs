using UnityEngine;
using UnityEngine.EventSystems;

using UnityEngine.UI;

public class UIMenu : MonoBehaviour
{

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

    public void MoveUp()
    {
        currentSelection = currentSelection.FindSelectableOnUp();
        currentSelection.Select();
    }
    public void Click()
    {
        currentSelection.animator.SetTrigger("Pressed");
        currentSelection.gameObject.GetComponent<Button>().onClick.Invoke();
    }


}
