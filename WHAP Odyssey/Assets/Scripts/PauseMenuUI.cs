using UnityEngine;

public class PauseMenuUI : MonoBehaviour {

    public Animator m_Anim;

    public void Quit() {
        Application.Quit();
    }

    public void Resume() {
        if (GameObject.Find("KP").GetComponent<PlayerControl>().InventoryOpen == false) {
            if (GameObject.Find("KP").GetComponent<PlayerControl>().BuyMenuOpen == false) {
                m_Anim.SetTrigger("None");
                GameObject.Find("KP").GetComponent<PlayerControl>().GameMenuOpen = false;
                GameObject.Find("KP").GetComponent<PlayerControl>().BuyMenuWeapon.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().BuyMenuItems.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().BuyMenuArmor.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().BuyMenuCloseButton.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().InventoryWeapon.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().InventoryItems.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().InventoryArmor.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().InventoryCloseButton.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().InGameMenuCloseButton.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().QuitButton.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().ControlsButton.SetActive(true);
            }            
        }    
    }

    public void Close()
    {
        if (GameObject.Find("KP").GetComponent<PlayerControl>().GameMenuOpen == false)
        {
            if (GameObject.Find("KP").GetComponent<PlayerControl>().BuyMenuOpen == false)
            {
                m_Anim.SetTrigger("None");
                GameObject.Find("KP").GetComponent<PlayerControl>().InventoryOpen = false;
                GameObject.Find("KP").GetComponent<PlayerControl>().BuyMenuWeapon.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().BuyMenuItems.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().BuyMenuArmor.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().BuyMenuCloseButton.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().InventoryWeapon.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().InventoryItems.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().InventoryArmor.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().InventoryCloseButton.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().InGameMenuCloseButton.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().QuitButton.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().ControlsButton.SetActive(true);
            }
        }
    }

    public void CloseBuyMenu() {
        if (GameObject.Find("KP").GetComponent<PlayerControl>().GameMenuOpen == false)
        {
            if (GameObject.Find("KP").GetComponent<PlayerControl>().InventoryOpen == false)
            {
                m_Anim.SetTrigger("None");
                GameObject.Find("KP").GetComponent<PlayerControl>().BuyMenuOpen = false;
                GameObject.Find("KP").GetComponent<PlayerControl>().BuyMenuWeapon.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().BuyMenuItems.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().BuyMenuArmor.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().BuyMenuCloseButton.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().InventoryWeapon.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().InventoryItems.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().InventoryArmor.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().InventoryCloseButton.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().InGameMenuCloseButton.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().QuitButton.SetActive(true);
                GameObject.Find("KP").GetComponent<PlayerControl>().ControlsButton.SetActive(true);
            }
        }
    }

    void Awake() {
        m_Anim = GetComponent<Animator>();
    }
}
