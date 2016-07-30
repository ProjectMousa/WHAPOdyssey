using UnityEngine;
using System.Collections;

public class Blacksmith : MonoBehaviour {

    public GameObject player;

    // Use this for initialization
    void Start () {
	
	}

    void Awake() {
        player = GameObject.Find("KP");
    }
	
	// Update is called once per frame
	void Update () {
        float PlayerNear = Vector3.Distance(player.transform.position, transform.position);
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (PlayerNear <= 0.2)
            {
                if (player.GetComponent<PlayerControl>().BuyMenuOpen == false)
                {
                    player.GetComponent<PlayerControl>().OpenBuyMenu();
                }
                else if (player.GetComponent<PlayerControl>().BuyMenuOpen == true)
                {
                    player.GetComponent<PlayerControl>().CloseBuyMenu();
                }
            }
            if (PlayerNear > 0.2) {
                if (player.GetComponent<PlayerControl>().BuyMenuOpen == true)
                {
                    player.GetComponent<PlayerControl>().CloseBuyMenu();
                }
            }
        }
        if (PlayerNear <= 0.2) {
            GameObject.Find("BuyAvailable").GetComponent<Animator>().SetBool("BuyAvailable", true);
        }
        if (PlayerNear > 0.2) {
            GameObject.Find("BuyAvailable").GetComponent<Animator>().SetBool("BuyAvailable", false);
            if (player.GetComponent<PlayerControl>().BuyMenuOpen == true) {
                player.GetComponent<PlayerControl>().CloseBuyMenu();
            }
        }
    }
}
