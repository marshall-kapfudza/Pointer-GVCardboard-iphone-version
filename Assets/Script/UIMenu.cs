using UnityEngine.UI;
using UnityEngine;

public class UIMenu : MonoBehaviour
{
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

    public void ExitMenu()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }


}
