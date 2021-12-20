using UnityEngine;
using UnityEngine.EventSystems;
public class UIMenu : MonoBehaviour
{
    //public int currentSelection = 0;
    //public GameObject[] buttons;
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

    public void Move()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(menuFirstButton);
    }
    /* public void MoveUp()
     {
         if (currentSelection == 0)
         {
             currentSelection--;
         }
         buttons[currentSelection].GetComponent<Animator>().Play("ButtonAnimation");
     }

     public void MoveDown()
     {
         if (currentSelection == 2)
         {
             currentSelection++;
         }
         buttons[currentSelection].GetComponent<Animator>().Play("ButtonAnimation");
     }

     private void OnEnable()
     {
         currentSelection = 0;
         buttons[currentSelection].GetComponent<Animator>().Play("ButtonAnimation");

     }*/
}
