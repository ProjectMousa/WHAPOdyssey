using UnityEngine;
using UnityEngine.UI;

public class UIOverlay : MonoBehaviour {
    [SerializeField]
    private Text HealthActual;
    [SerializeField]
    private Text CoinsActual;
    [SerializeField]
    private Text WeaponSelectedText;
    [SerializeField]
    private Text ArmorSelectedText;
    [SerializeField]
    private Text WeaponSelectedBuyText;
    [SerializeField]
    private Text ArmorSelectedBuyText;
    [SerializeField]
    private Text WeaponSelectedPrice;
    [SerializeField]
    private Text ArmorSelectedPrice;

    public void SetHealthUI(float current, float max) {
        HealthActual.text = "HEALTH" + " " + current + "/" + max;
    }

    public void SetCoinsUI(int Coins)
    {
        CoinsActual.text = Coins + " " + "COINS";
    }

    public void SetWeaponText(string weapon) {
        WeaponSelectedText.text = weapon;
    }

    public void SetArmorText(string armor) {
        ArmorSelectedText.text = armor;
    }

    public void SetWeaponBuyText(string weapon) {
        WeaponSelectedBuyText.text = weapon;
    }

    public void SetArmorBuyText(string armor)
    {
        ArmorSelectedBuyText.text = armor;
    }

    public void SetWeaponPriceText(int price) {
        WeaponSelectedPrice.text = price + " " + "COINS";
    }

    public void SetArmorPriceText(int price)
    {
        ArmorSelectedPrice.text = price + " " + "COINS";
    }
}
