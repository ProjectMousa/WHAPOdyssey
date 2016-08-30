using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    public float PlayerCurrentHealth = 100;
    public float PlayerMaxHealth = 100;
    public float RespawnPlayerXPos = 0;
    public float RespawnPlayerYPos = 0;
    float RespawnPlayerZPos = 0;
    int PlayerDeaths = 0;
    int setx = 0;
    int sety = 0;
    float XSpeed = 0.1F;
    float XChange = 0F;
    float PositionX = 0F;
    public bool Swing = false;
    Animator m_Anim;
    int FallBoundary = -20;
    bool SwingSword = false;
    bool SwingAxe = false;
    public float DamageAbsorb; //number is how much damage will be taken, 100 is full, 75 is 75%.
    public bool InventoryOpen = false;
    public bool GameMenuOpen = false;
    public bool BuyMenuOpen = false;

    bool NoWeaponActive = false;
    bool WoodWeakLesserSwordActive = false;
    bool WoodMediumLesserSwordActive = false;
    bool WoodStrongLesserSwordActive = false;
    bool IronWeakLesserSwordActive = false;
    bool IronMediumLesserSwordActive = false;
    bool IronStrongLesserSwordActive = false;
    bool SteelWeakLesserSwordActive = false;
    bool SteelMediumLesserSwordActive = false;
    bool SteelStrongLesserSwordActive = false;

    bool WoodWeakGreatSwordActive = false;
    bool WoodMediumGreatSwordActive = false;
    bool WoodStrongGreatSwordActive = false;
    bool IronWeakGreatSwordActive = false;
    bool IronMediumGreatSwordActive = false;
    bool IronStrongGreatSwordActive = false;
    bool SteelWeakGreatSwordActive = false;
    bool SteelMediumGreatSwordActive = false;
    bool SteelStrongGreatSwordActive = false;

    bool WoodWeakBroadSwordActive = false;
    bool WoodMediumBroadSwordActive = false;
    bool WoodStrongBroadSwordActive = false;
    bool IronWeakBroadSwordActive = false;
    bool IronMediumBroadSwordActive = false;
    bool IronStrongBroadSwordActive = false;
    bool SteelWeakBroadSwordActive = false;
    bool SteelMediumBroadSwordActive = false;
    bool SteelStrongBroadSwordActive = false;

    bool WoodWeakCommonAxeActive = false;
    bool WoodMediumCommonAxeActive = false;
    bool WoodStrongCommonAxeActive = false;
    bool IronWeakCommonAxeActive = false;
    bool IronMediumCommonAxeActive = false;
    bool IronStrongCommonAxeActive = false;
    bool SteelWeakCommonAxeActive = false;
    bool SteelMediumCommonAxeActive = false;
    bool SteelStrongCommonAxeActive = false;

    bool WoodWeakBattleAxeActive = false;
    bool WoodMediumBattleAxeActive = false;
    bool WoodStrongBattleAxeActive = false;
    bool IronWeakBattleAxeActive = false;
    bool IronMediumBattleAxeActive = false;
    bool IronStrongBattleAxeActive = false;
    bool SteelWeakBattleAxeActive = false;
    bool SteelMediumBattleAxeActive = false;
    bool SteelStrongBattleAxeActive = false;

    bool WoodWeakWarAxeActive = false;
    bool WoodMediumWarAxeActive = false;
    bool WoodStrongWarAxeActive = false;
    bool IronWeakWarAxeActive = false;
    bool IronMediumWarAxeActive = false;
    bool IronStrongWarAxeActive = false;
    bool SteelWeakWarAxeActive = false;
    bool SteelMediumWarAxeActive = false;
    bool SteelStrongWarAxeActive = false;

    int Coins = 99999;
    public bool Blocking = false;
    public float blockTimer;
    public float blockingTimer;

    bool NoArmorActive = false;
    bool LeatherArmorActive = false;
    bool IronArmorActive = false;
    bool SteelArmorActive = false;

    public int CurrentWeapon;
    public int CurrentArmor;
    public int CurrentWeaponBuy;
    public int CurrentArmorBuy;

    [SerializeField]
    private GameObject pauseMenuUI;

    public GameObject BuyMenuWeapon;
    public GameObject BuyMenuItems;
    public GameObject BuyMenuArmor;
    public GameObject BuyMenuCloseButton;
    public GameObject InventoryWeapon;
    public GameObject InventoryItems;
    public GameObject InventoryArmor;
    public GameObject InventoryCloseButton;
    public GameObject InGameMenuCloseButton;
    public GameObject QuitButton;
    public GameObject ControlsButton;

    bool WoodWeakLesserSwordBought = false;
    bool WoodMediumLesserSwordBought = false;
    bool WoodStrongLesserSwordBought = false;
    bool IronWeakLesserSwordBought = false;
    bool IronMediumLesserSwordBought = false;
    bool IronStrongLesserSwordBought = false;
    bool SteelWeakLesserSwordBought = false;
    bool SteelMediumLesserSwordBought = false;
    bool SteelStrongLesserSwordBought = false;

    bool WoodWeakGreatSwordBought = false;
    bool WoodMediumGreatSwordBought = false;
    bool WoodStrongGreatSwordBought = false;
    bool IronWeakGreatSwordBought = false;
    bool IronMediumGreatSwordBought = false;
    bool IronStrongGreatSwordBought = false;
    bool SteelWeakGreatSwordBought = false;
    bool SteelMediumGreatSwordBought = false;
    bool SteelStrongGreatSwordBought = false;

    bool WoodWeakBroadSwordBought = false;
    bool WoodMediumBroadSwordBought = false;
    bool WoodStrongBroadSwordBought = false;
    bool IronWeakBroadSwordBought = false;
    bool IronMediumBroadSwordBought = false;
    bool IronStrongBroadSwordBought = false;
    bool SteelWeakBroadSwordBought = false;
    bool SteelMediumBroadSwordBought = false;
    bool SteelStrongBroadSwordBought = false;

    bool WoodWeakCommonAxeBought = false;
    bool WoodMediumCommonAxeBought = false;
    bool WoodStrongCommonAxeBought = false;
    bool IronWeakCommonAxeBought = false;
    bool IronMediumCommonAxeBought = false;
    bool IronStrongCommonAxeBought = false;
    bool SteelWeakCommonAxeBought = false;
    bool SteelMediumCommonAxeBought = false;
    bool SteelStrongCommonAxeBought = false;

    bool WoodWeakBattleAxeBought = false;
    bool WoodMediumBattleAxeBought = false;
    bool WoodStrongBattleAxeBought = false;
    bool IronWeakBattleAxeBought = false;
    bool IronMediumBattleAxeBought = false;
    bool IronStrongBattleAxeBought = false;
    bool SteelWeakBattleAxeBought = false;
    bool SteelMediumBattleAxeBought = false;
    bool SteelStrongBattleAxeBought = false;

    bool WoodWeakWarAxeBought = false;
    bool WoodMediumWarAxeBought = false;
    bool WoodStrongWarAxeBought = false;
    bool IronWeakWarAxeBought = false;
    bool IronMediumWarAxeBought = false;
    bool IronStrongWarAxeBought = false;
    bool SteelWeakWarAxeBought = false;
    bool SteelMediumWarAxeBought = false;
    bool SteelStrongWarAxeBought = false;

    bool LeatherArmorBought = false;
    bool IronArmorBought = false;
    bool SteelArmorBought = false;

    public int WeaponPrice;
    public int ArmorPrice;

    int WeaponsBought = 0;
    int ArmorsBought = 0;

    bool blockingForTimer;

    [SerializeField]
    private RectTransform blockBarRect;

    public bool Blockable = true;

    //if setting x or y respawn, use SetRespawnX or Y() and put amount in thing.
    //if damaging do DamagePlayer() and put amount in thing.

    // Use this for initialization
    void Start () {

        blockingForTimer = false;

        ChangeCoins(0);

        BuyMenuWeapon.SetActive(true);
        BuyMenuItems.SetActive(true);
        BuyMenuArmor.SetActive(true);
        BuyMenuCloseButton.SetActive(true);
        InventoryWeapon.SetActive(true);
        InventoryItems.SetActive(true);
        InventoryArmor.SetActive(true);
        InventoryCloseButton.SetActive(true);
        InGameMenuCloseButton.SetActive(true);
        QuitButton.SetActive(true);
        ControlsButton.SetActive(true);

        ChangeWeapon(0, true); //starting weapon
        ChangeArmor(0, true); //starting armor
        ChangeWeaponBuy(0, true);
        ChangeArmorBuy(0, true);

        pauseMenuUI.GetComponent<PauseMenuUI>().m_Anim.ResetTrigger("InGameMenu");
        pauseMenuUI.GetComponent<PauseMenuUI>().m_Anim.ResetTrigger("Inventory");
        pauseMenuUI.GetComponent<PauseMenuUI>().m_Anim.ResetTrigger("BuyMenu");
        pauseMenuUI.GetComponent<PauseMenuUI>().m_Anim.ResetTrigger("Controls");
        pauseMenuUI.GetComponent<PauseMenuUI>().m_Anim.ResetTrigger("None");

        SetRespawnX(-0.513f);
        SetRespawnY(-0.010924f);

        if (NoArmorActive == true)
        {
            DamageAbsorb = 100;
            m_Anim.SetBool("NoArmor", true);
            GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
            GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
            GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
        }
        if (LeatherArmorActive == true)
        {
            DamageAbsorb = 80;
            m_Anim.SetBool("LeatherArmor", true);
            GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
            GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
            GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
        }
        if (IronArmorActive == true)
        {
            DamageAbsorb = 60;
            m_Anim.SetBool("IronArmor", true);
            GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
            GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
            GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
        }
        if (SteelArmorActive == true)
        {
            DamageAbsorb = 40;
            m_Anim.SetBool("SteelArmor", true);
            GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
            GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
            GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
        }
    }
    void Awake () {     
        m_Anim = GetComponent<Animator>();

        BuyMenuWeapon = GameObject.Find("BuyMenuWeapon");
        BuyMenuItems = GameObject.Find("BuyMenuItems");
        BuyMenuArmor = GameObject.Find("BuyMenuArmor");
        BuyMenuCloseButton = GameObject.Find("BuyMenuCloseButton");
        InventoryWeapon = GameObject.Find("InventoryWeapon");
        InventoryItems = GameObject.Find("InventoryItems");
        InventoryArmor = GameObject.Find("InventoryArmor");
        InventoryCloseButton = GameObject.Find("InventoryCloseButton");
        InGameMenuCloseButton = GameObject.Find("InGameMenuCloseButton");
        QuitButton = GameObject.Find("QuitButton");
        ControlsButton = GameObject.Find("ControlsButton");
    }
 
	// Update is called once per frame
	void Update () {

        if (blockTimer == 0)
        {
            if (blockingTimer == 0)
            {
                SetBlockBar(3, 3);
            }
            else {
                SetBlockBar(blockingTimer, 3);
            } 
        }
        else {       
            SetBlockBar(blockTimer, 3);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameMenuOpen == false)
            {
                if (InventoryOpen == false)
                {
                    if (BuyMenuOpen == false)
                    {
                        ControlsButton.SetActive(true);
                        QuitButton.SetActive(true);
                        InGameMenuCloseButton.SetActive(true);
                        pauseMenuUI.GetComponent<PauseMenuUI>().m_Anim.SetTrigger("InGameMenu");
                        GameMenuOpen = true;
                        InventoryWeapon.SetActive(false);
                        InventoryItems.SetActive(false);
                        InventoryArmor.SetActive(false);
                        InventoryCloseButton.SetActive(false);
                        BuyMenuWeapon.SetActive(false);
                        BuyMenuItems.SetActive(false);
                        BuyMenuArmor.SetActive(false);
                        BuyMenuCloseButton.SetActive(false);
                    }
                }
            }
            else if (GameMenuOpen == true)
            {
                pauseMenuUI.GetComponent<PauseMenuUI>().m_Anim.SetTrigger("None");
                GameMenuOpen = false;
                BuyMenuWeapon.SetActive(true);
                BuyMenuItems.SetActive(true);
                BuyMenuArmor.SetActive(true);
                BuyMenuCloseButton.SetActive(true);
                InventoryWeapon.SetActive(true);
                InventoryItems.SetActive(true);
                InventoryArmor.SetActive(true);
                InventoryCloseButton.SetActive(true);
                InGameMenuCloseButton.SetActive(true);
                QuitButton.SetActive(true);
                ControlsButton.SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (InventoryOpen == false)
            {
                if (GameMenuOpen == false) {
                    if (BuyMenuOpen == false) {
                        InventoryWeapon.SetActive(true);
                        InventoryItems.SetActive(true);
                        InventoryArmor.SetActive(true);
                        InventoryCloseButton.SetActive(true);
                        pauseMenuUI.GetComponent<PauseMenuUI>().m_Anim.SetTrigger("Inventory");
                        InventoryOpen = true;
                        BuyMenuWeapon.SetActive(false);
                        BuyMenuItems.SetActive(false);
                        BuyMenuArmor.SetActive(false);
                        BuyMenuCloseButton.SetActive(false);
                        QuitButton.SetActive(false);
                        ControlsButton.SetActive(false);
                        InGameMenuCloseButton.SetActive(false);
                        ChangeWeapon(CurrentWeapon, true);
                        ChangeArmor(CurrentArmor, true);
                    }              
                }           
            }
            else if (InventoryOpen == true) {
                pauseMenuUI.GetComponent<PauseMenuUI>().m_Anim.SetTrigger("None");
                InventoryOpen = false;
                BuyMenuWeapon.SetActive(true);
                BuyMenuItems.SetActive(true);
                BuyMenuArmor.SetActive(true);
                BuyMenuCloseButton.SetActive(true);
                InventoryWeapon.SetActive(true);
                InventoryItems.SetActive(true);
                InventoryArmor.SetActive(true);
                InventoryCloseButton.SetActive(true);
                InGameMenuCloseButton.SetActive(true);
                QuitButton.SetActive(true);
                ControlsButton.SetActive(true);
            }
        }

        if (blockTimer > 0)
        {
            blockTimer -= Time.unscaledDeltaTime;
        }

        if (blockTimer < 0)
        {
            blockTimer = 0;
        }

        if (blockingTimer > 0)
        {
            blockingTimer -= Time.unscaledDeltaTime;
        }

        if (blockingTimer < 0)
        {
            blockingTimer = 0;
        }

        if (blockingTimer == 0) {
            if (Blocking == true)
            {
                blockTimer = 3;
            }
        }

        if (blockTimer == 3) {
            ReleaseBlock();
            Blockable = false;
        }

        if (blockTimer == 0) {
            Blockable = true;
        }

        if (Blockable == false) {
            GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Block", false);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        { //Add for new weapons                               
            if (Blocking == false)
            {
                if (InventoryOpen == false)
                {
                    if (GameMenuOpen == false)
                    {
                        if (BuyMenuOpen == false)
                        {
                            Swing = true;
                            //lesser swords
                            if (WoodWeakLesserSwordActive == true)
                            {
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("WoodWeakLesserSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().damage = 5;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (WoodMediumLesserSwordActive == true)
                            {
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("WoodMediumLesserSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().damage = 10;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (WoodStrongLesserSwordActive == true)
                            {
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("WoodStrongLesserSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().damage = 15;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (IronWeakLesserSwordActive == true)
                            {
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("IronWeakLesserSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().damage = 20;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (IronMediumLesserSwordActive == true)
                            {
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("IronMediumLesserSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().damage = 25;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (IronStrongLesserSwordActive == true)
                            {
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("IronStrongLesserSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().damage = 30;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (SteelWeakLesserSwordActive == true)
                            {
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("SteelWeakLesserSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().damage = 35;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (SteelMediumLesserSwordActive == true)
                            {
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("SteelMediumLesserSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().damage = 40;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (SteelStrongLesserSwordActive == true)
                            {
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("SteelStrongLesserSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("LesserSword").GetComponent<LesserSword>().damage = 45;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            //great swords
                            if (WoodWeakGreatSwordActive == true)
                            {
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("WoodWeakGreatSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().damage = 50;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (WoodMediumGreatSwordActive == true)
                            {
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("WoodMediumGreatSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().damage = 55;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (WoodStrongGreatSwordActive == true)
                            {
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("WoodStrongGreatSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().damage = 60;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (IronWeakGreatSwordActive == true)
                            {
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("IronWeakGreatSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().damage = 65;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (IronMediumGreatSwordActive == true)
                            {
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("IronMediumGreatSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().damage = 70;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (IronStrongGreatSwordActive == true)
                            {
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("IronStrongGreatSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().damage = 75;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (SteelWeakGreatSwordActive == true)
                            {
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("SteelWeakGreatSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().damage = 80;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (SteelMediumGreatSwordActive == true)
                            {
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("SteelMediumGreatSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().damage = 85;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (SteelStrongGreatSwordActive == true)
                            {
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("SteelStrongGreatSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("GreatSword").GetComponent<GreatSword>().damage = 90;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            //broad swords
                            if (WoodWeakBroadSwordActive == true)
                            {
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("WoodWeakBroadSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().damage = 95;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (WoodMediumBroadSwordActive == true)
                            {
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("WoodMediumBroadSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().damage = 100;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (WoodStrongBroadSwordActive == true)
                            {
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("WoodStrongBroadSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().damage = 105;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (IronWeakBroadSwordActive == true)
                            {
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("IronWeakBroadSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().damage = 110;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (IronMediumBroadSwordActive == true)
                            {
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("IronMediumBroadSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().damage = 115;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (IronStrongBroadSwordActive == true)
                            {
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("IronStrongBroadSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().damage = 120;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (SteelWeakBroadSwordActive == true)
                            {
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("SteelWeakBroadSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().damage = 125;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (SteelMediumBroadSwordActive == true)
                            {
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("SteelMediumBroadSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().damage = 130;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (SteelStrongBroadSwordActive == true)
                            {
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("SteelStrongBroadSwordSwing", true);
                                SwingSword = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Sword", true);
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("BroadSword").GetComponent<BroadSword>().damage = 135;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            //common axes
                            if (WoodWeakCommonAxeActive == true)
                            {
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("WoodWeakCommonAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().damage = 15;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (WoodMediumCommonAxeActive == true)
                            {
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("WoodMediumCommonAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().damage = 20;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (WoodStrongCommonAxeActive == true)
                            {
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("WoodStrongCommonAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().damage = 25;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (IronWeakCommonAxeActive == true)
                            {
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("IronWeakCommonAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().damage = 30;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (IronMediumCommonAxeActive == true)
                            {
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("IronMediumCommonAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().damage = 35;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (IronStrongCommonAxeActive == true)
                            {
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("IronStrongCommonAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().damage = 40;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (SteelWeakCommonAxeActive == true)
                            {
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("SteelWeakCommonAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().damage = 45;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (SteelMediumCommonAxeActive == true)
                            {
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("SteelMediumCommonAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().damage = 50;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (SteelStrongCommonAxeActive == true)
                            {
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("SteelStrongCommonAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().damage = 55;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            //battle axes
                            if (WoodWeakBattleAxeActive == true)
                            {
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("WoodWeakBattleAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().damage = 60;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (WoodMediumBattleAxeActive == true)
                            {
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("WoodMediumBattleAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().damage = 65;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (WoodStrongBattleAxeActive == true)
                            {
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("WoodStrongBattleAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().damage = 70;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (IronWeakBattleAxeActive == true)
                            {
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("IronWeakBattleAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().damage = 75;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (IronMediumBattleAxeActive == true)
                            {
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("IronMediumBattleAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().damage = 80;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (IronStrongBattleAxeActive == true)
                            {
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("IronStrongBattleAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().damage = 85;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (SteelWeakBattleAxeActive == true)
                            {
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("SteelWeakBattleAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().damage = 90;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (SteelMediumBattleAxeActive == true)
                            {
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("SteelMediumBattleAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().damage = 95;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (SteelStrongBattleAxeActive == true)
                            {
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("SteelStrongBattleAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().damage = 100;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            //war axes
                            if (WoodWeakWarAxeActive == true)
                            {
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("WoodWeakWarAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().damage = 105;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (WoodMediumWarAxeActive == true)
                            {
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("WoodMediumWarAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().damage = 110;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (WoodStrongWarAxeActive == true)
                            {
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("WoodStrongWarAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().damage = 115;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (IronWeakWarAxeActive == true)
                            {
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("IronWeakWarAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().damage = 120;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (IronMediumWarAxeActive == true)
                            {
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("IronMediumWarAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().damage = 125;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (IronStrongWarAxeActive == true)
                            {
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("IronStrongWarAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().damage = 130;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (SteelWeakWarAxeActive == true)
                            {
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("SteelWeakWarAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().damage = 135;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (SteelMediumWarAxeActive == true)
                            {
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("SteelMediumWarAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().damage = 140;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                            if (SteelStrongWarAxeActive == true)
                            {
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("SteelStrongWarAxeSwing", true);
                                SwingAxe = true;
                                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Axe", true);
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().Active = true;
                                GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", true);
                                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
                                GameObject.Find("WarAxe").GetComponent<WarAxe>().damage = 145;
                                if (NoArmorActive == true)
                                {
                                    m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
                                }
                                if (LeatherArmorActive == true)
                                {
                                    m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
                                }
                                if (IronArmorActive == true)
                                {
                                    m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
                                }
                                if (SteelArmorActive == true)
                                {
                                    m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
                                }
                            }
                        }
                    }
                }
            }
        }

            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                Swing = false;
                SwingSword = false;
                SwingAxe = false;
                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().Sword = false;
                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().Axe = false;
                //lesser swords
                if (WoodWeakLesserSwordActive == true)
                {
                    GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("WoodWeakLesserSwordSwing", false);
                    GameObject.Find("LesserSword").GetComponent<LesserSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (WoodMediumLesserSwordActive == true)
                {
                    GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("WoodMediumLesserSwordSwing", false);
                    GameObject.Find("LesserSword").GetComponent<LesserSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (WoodStrongLesserSwordActive == true)
                {
                    GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("WoodStrongLesserSwordSwing", false);
                    GameObject.Find("LesserSword").GetComponent<LesserSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (IronWeakLesserSwordActive == true)
                {
                    GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("IronWeakLesserSwordSwing", false);
                    GameObject.Find("LesserSword").GetComponent<LesserSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (IronMediumLesserSwordActive == true)
                {
                    GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("IronMediumLesserSwordSwing", false);
                    GameObject.Find("LesserSword").GetComponent<LesserSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (IronStrongLesserSwordActive == true)
                {
                    GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("IronStrongLesserSwordSwing", false);
                    GameObject.Find("LesserSword").GetComponent<LesserSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (SteelWeakLesserSwordActive == true)
                {
                    GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("SteelWeakLesserSwordSwing", false);
                    GameObject.Find("LesserSword").GetComponent<LesserSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (SteelMediumLesserSwordActive == true)
                {
                    GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("SteelMediumLesserSwordSwing", false);
                    GameObject.Find("LesserSword").GetComponent<LesserSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (SteelStrongLesserSwordActive == true)
                {
                    GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("SteelStrongLesserSwordSwing", false);
                    GameObject.Find("LesserSword").GetComponent<LesserSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                //great swords
                if (WoodWeakGreatSwordActive == true)
                {
                    GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("WoodWeakGreatSwordSwing", false);
                    GameObject.Find("GreatSword").GetComponent<GreatSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (WoodMediumGreatSwordActive == true)
                {
                    GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("WoodMediumGreatSwordSwing", false);
                    GameObject.Find("GreatSword").GetComponent<GreatSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (WoodStrongGreatSwordActive == true)
                {
                    GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("WoodStrongGreatSwordSwing", false);
                    GameObject.Find("GreatSword").GetComponent<GreatSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (IronWeakGreatSwordActive == true)
                {
                    GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("IronWeakGreatSwordSwing", false);
                    GameObject.Find("GreatSword").GetComponent<GreatSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (IronMediumGreatSwordActive == true)
                {
                    GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("IronMediumGreatSwordSwing", false);
                    GameObject.Find("GreatSword").GetComponent<GreatSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (IronStrongGreatSwordActive == true)
                {
                    GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("IronStrongGreatSwordSwing", false);
                    GameObject.Find("GreatSword").GetComponent<GreatSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (SteelWeakGreatSwordActive == true)
                {
                    GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("SteelWeakGreatSwordSwing", false);
                    GameObject.Find("GreatSword").GetComponent<GreatSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (SteelMediumGreatSwordActive == true)
                {
                    GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("SteelMediumGreatSwordSwing", false);
                    GameObject.Find("GreatSword").GetComponent<GreatSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (SteelStrongGreatSwordActive == true)
                {
                    GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("SteelStrongGreatSwordSwing", false);
                    GameObject.Find("GreatSword").GetComponent<GreatSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                //broad swords
                if (WoodWeakBroadSwordActive == true)
                {
                    GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("WoodWeakBroadSwordSwing", false);
                    GameObject.Find("BroadSword").GetComponent<BroadSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (WoodMediumBroadSwordActive == true)
                {
                    GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("WoodMediumBroadSwordSwing", false);
                    GameObject.Find("BroadSword").GetComponent<BroadSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (WoodStrongBroadSwordActive == true)
                {
                    GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("WoodStrongBroadSwordSwing", false);
                    GameObject.Find("BroadSword").GetComponent<BroadSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (IronWeakBroadSwordActive == true)
                {
                    GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("IronWeakBroadSwordSwing", false);
                    GameObject.Find("BroadSword").GetComponent<BroadSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (IronMediumBroadSwordActive == true)
                {
                    GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("IronMediumBroadSwordSwing", false);
                    GameObject.Find("BroadSword").GetComponent<BroadSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (IronStrongBroadSwordActive == true)
                {
                    GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("IronStrongBroadSwordSwing", false);
                    GameObject.Find("BroadSword").GetComponent<BroadSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (SteelWeakBroadSwordActive == true)
                {
                    GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("SteelWeakBroadSwordSwing", false);
                    GameObject.Find("BroadSword").GetComponent<BroadSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (SteelMediumBroadSwordActive == true)
                {
                    GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("SteelMediumBroadSwordSwing", false);
                    GameObject.Find("BroadSword").GetComponent<BroadSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                if (SteelStrongBroadSwordActive == true)
                {
                    GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("SteelStrongBroadSwordSwing", false);
                    GameObject.Find("BroadSword").GetComponent<BroadSword>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("Swing", false);
                    }
                }
                //common axes
                if (WoodWeakCommonAxeActive == true)
                {
                    GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("WoodWeakCommonAxeSwing", false);
                    GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (WoodMediumCommonAxeActive == true)
                {
                    GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("WoodMediumCommonAxeSwing", false);
                    GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (WoodStrongCommonAxeActive == true)
                {
                    GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("WoodStrongCommonAxeSwing", false);
                    GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (IronWeakCommonAxeActive == true)
                {
                    GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("IronWeakCommonAxeSwing", false);
                    GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (IronMediumCommonAxeActive == true)
                {
                    GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("IronMediumCommonAxeSwing", false);
                    GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (IronStrongCommonAxeActive == true)
                {
                    GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("IronStrongCommonAxeSwing", false);
                    GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (SteelWeakCommonAxeActive == true)
                {
                    GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("SteelWeakCommonAxeSwing", false);
                    GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (SteelMediumCommonAxeActive == true)
                {
                    GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("SteelMediumCommonAxeSwing", false);
                    GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (SteelStrongCommonAxeActive == true)
                {
                    GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("SteelStrongCommonAxeSwing", false);
                    GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                //battle axes
                if (WoodWeakBattleAxeActive == true)
                {
                    GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("WoodWeakBattleAxeSwing", false);
                    GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (WoodMediumBattleAxeActive == true)
                {
                    GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("WoodMediumBattleAxeSwing", false);
                    GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (WoodStrongBattleAxeActive == true)
                {
                    GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("WoodStrongBattleAxeSwing", false);
                    GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (IronWeakBattleAxeActive == true)
                {
                    GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("IronWeakBattleAxeSwing", false);
                    GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (IronMediumBattleAxeActive == true)
                {
                    GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("IronMediumBattleAxeSwing", false);
                    GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (IronStrongBattleAxeActive == true)
                {
                    GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("IronStrongBattleAxeSwing", false);
                    GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (SteelWeakBattleAxeActive == true)
                {
                    GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("SteelWeakBattleAxeSwing", false);
                    GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (SteelMediumBattleAxeActive == true)
                {
                    GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("SteelMediumBattleAxeSwing", false);
                    GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (SteelStrongBattleAxeActive == true)
                {
                    GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("SteelStrongBattleAxeSwing", false);
                    GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                //war axes
                if (WoodWeakWarAxeActive == true)
                {
                    GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("WoodWeakWarAxeSwing", false);
                    GameObject.Find("WarAxe").GetComponent<WarAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (WoodMediumWarAxeActive == true)
                {
                    GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("WoodMediumWarAxeSwing", false);
                    GameObject.Find("WarAxe").GetComponent<WarAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (WoodStrongWarAxeActive == true)
                {
                    GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("WoodStrongWarAxeSwing", false);
                    GameObject.Find("WarAxe").GetComponent<WarAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (IronWeakWarAxeActive == true)
                {
                    GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("IronWeakWarAxeSwing", false);
                    GameObject.Find("WarAxe").GetComponent<WarAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (IronMediumWarAxeActive == true)
                {
                    GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("IronMediumWarAxeSwing", false);
                    GameObject.Find("WarAxe").GetComponent<WarAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (IronStrongWarAxeActive == true)
                {
                    GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("IronStrongWarAxeSwing", false);
                    GameObject.Find("WarAxe").GetComponent<WarAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (SteelWeakWarAxeActive == true)
                {
                    GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("SteelWeakWarAxeSwing", false);
                    GameObject.Find("WarAxe").GetComponent<WarAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (SteelMediumWarAxeActive == true)
                {
                    GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("SteelMediumWarAxeSwing", false);
                    GameObject.Find("WarAxe").GetComponent<WarAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
                if (SteelStrongWarAxeActive == true)
                {
                    GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("SteelStrongWarAxeSwing", false);
                    GameObject.Find("WarAxe").GetComponent<WarAxe>().Active = false;
                    GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
                    GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);
                    if (Blocking == false)
                    {
                        GameObject.Find("KP").GetComponent<PlayerControl>().m_Anim.SetBool("SwingAxe", false);
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                if (InventoryOpen == false)
                {
                    if (GameMenuOpen == false)
                    {
                        if (BuyMenuOpen == false)
                        {
                            if (blockTimer <= 0)
                            {
                                Block();
                            }
                        }
                    }
                }
            }


        if (Input.GetKeyUp(KeyCode.Mouse1))
        {

            if (Blocking == true)
            {
                blockingTimer = 0;
                blockTimer = 3;
            }

            ReleaseBlock();
            Blockable = false;
            GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("Block", false);

        }

            if (transform.position.y <= FallBoundary)
            {
                DamagePlayer(9999999);
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetHealthUI(100, 100);
            }       
    }

    void Block()
    {
        GameObject.Find("KP_Arm").GetComponent<ArmSwing>().SwordBlock();
        if (Blockable == true) {
            blockingForTimer = true;

            if (blockingForTimer == true)
            {
                blockingTimer = 3;
                blockingForTimer = false;
            }

            Swing = false;
            GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", true);
            GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", true);
            if (NoArmorActive == true)
            {
                m_Anim.SetBool("NoArmor", true);
                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
            }
            if (LeatherArmorActive == true)
            {
                m_Anim.SetBool("LeatherArmor", true);
                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
            }
            if (IronArmorActive == true)
            {
                m_Anim.SetBool("IronArmor", true);
                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
            }
            if (SteelArmorActive == true)
            {
                m_Anim.SetBool("SteelArmor", true);
                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
            }
            m_Anim.SetBool("Swing", true);
            Blocking = true;
            //lesser swords
            if (WoodWeakLesserSwordActive == true)
            {
                GameObject.Find("LesserSword").GetComponent<LesserSword>().Block = true;
                GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("WoodWeakLesserSwordBlock", true);
            }
            if (WoodMediumLesserSwordActive == true)
            {
                GameObject.Find("LesserSword").GetComponent<LesserSword>().Block = true;
                GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("WoodMediumLesserSwordBlock", true);
            }
            if (WoodStrongLesserSwordActive == true)
            {
                GameObject.Find("LesserSword").GetComponent<LesserSword>().Block = true;
                GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("WoodStrongLesserSwordBlock", true);
            }
            if (IronWeakLesserSwordActive == true)
            {
                GameObject.Find("LesserSword").GetComponent<LesserSword>().Block = true;
                GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("IronWeakLesserSwordBlock", true);
            }
            if (IronMediumLesserSwordActive == true)
            {
                GameObject.Find("LesserSword").GetComponent<LesserSword>().Block = true;
                GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("IronMediumLesserSwordBlock", true);
            }
            if (IronStrongLesserSwordActive == true)
            {
                GameObject.Find("LesserSword").GetComponent<LesserSword>().Block = true;
                GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("IronStrongLesserSwordBlock", true);
            }
            if (SteelWeakLesserSwordActive == true)
            {
                GameObject.Find("LesserSword").GetComponent<LesserSword>().Block = true;
                GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("SteelWeakLesserSwordBlock", true);
            }
            if (SteelMediumLesserSwordActive == true)
            {
                GameObject.Find("LesserSword").GetComponent<LesserSword>().Block = true;
                GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("SteelMediumLesserSwordBlock", true);
            }
            if (SteelStrongLesserSwordActive == true)
            {
                GameObject.Find("LesserSword").GetComponent<LesserSword>().Block = true;
                GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("SteelStrongLesserSwordBlock", true);
            }
            //great swords
            if (WoodWeakGreatSwordActive == true)
            {
                GameObject.Find("GreatSword").GetComponent<GreatSword>().Block = true;
                GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("WoodWeakGreatSwordBlock", true);
            }
            if (WoodMediumGreatSwordActive == true)
            {
                GameObject.Find("GreatSword").GetComponent<GreatSword>().Block = true;
                GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("WoodMediumGreatSwordBlock", true);
            }
            if (WoodStrongGreatSwordActive == true)
            {
                GameObject.Find("GreatSword").GetComponent<GreatSword>().Block = true;
                GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("WoodStrongGreatSwordBlock", true);
            }
            if (IronWeakGreatSwordActive == true)
            {
                GameObject.Find("GreatSword").GetComponent<GreatSword>().Block = true;
                GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("IronWeakGreatSwordBlock", true);
            }
            if (IronMediumGreatSwordActive == true)
            {
                GameObject.Find("GreatSword").GetComponent<GreatSword>().Block = true;
                GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("IronMediumGreatSwordBlock", true);
            }
            if (IronStrongGreatSwordActive == true)
            {
                GameObject.Find("GreatSword").GetComponent<GreatSword>().Block = true;
                GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("IronStrongGreatSwordBlock", true);
            }
            if (SteelWeakGreatSwordActive == true)
            {
                GameObject.Find("GreatSword").GetComponent<GreatSword>().Block = true;
                GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("SteelWeakGreatSwordBlock", true);
            }
            if (SteelMediumGreatSwordActive == true)
            {
                GameObject.Find("GreatSword").GetComponent<GreatSword>().Block = true;
                GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("SteelMediumGreatSwordBlock", true);
            }
            if (SteelStrongGreatSwordActive == true)
            {
                GameObject.Find("GreatSword").GetComponent<GreatSword>().Block = true;
                GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("SteelStrongGreatSwordBlock", true);
            }
            //broad swords
            if (WoodWeakBroadSwordActive == true)
            {
                GameObject.Find("BroadSword").GetComponent<BroadSword>().Block = true;
                GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("WoodWeakBroadSwordBlock", true);
            }
            if (WoodMediumBroadSwordActive == true)
            {
                GameObject.Find("BroadSword").GetComponent<BroadSword>().Block = true;
                GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("WoodMediumBroadSwordBlock", true);
            }
            if (WoodStrongBroadSwordActive == true)
            {
                GameObject.Find("BroadSword").GetComponent<BroadSword>().Block = true;
                GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("WoodStrongBroadSwordBlock", true);
            }
            if (IronWeakBroadSwordActive == true)
            {
                GameObject.Find("BroadSword").GetComponent<BroadSword>().Block = true;
                GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("IronWeakBroadSwordBlock", true);
            }
            if (IronMediumBroadSwordActive == true)
            {
                GameObject.Find("BroadSword").GetComponent<BroadSword>().Block = true;
                GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("IronMediumBroadSwordBlock", true);
            }
            if (IronStrongBroadSwordActive == true)
            {
                GameObject.Find("BroadSword").GetComponent<BroadSword>().Block = true;
                GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("IronStrongBroadSwordBlock", true);
            }
            if (SteelWeakBroadSwordActive == true)
            {
                GameObject.Find("BroadSword").GetComponent<BroadSword>().Block = true;
                GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("SteelWeakBroadSwordBlock", true);
            }
            if (SteelMediumBroadSwordActive == true)
            {
                GameObject.Find("BroadSword").GetComponent<BroadSword>().Block = true;
                GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("SteelMediumBroadSwordBlock", true);
            }
            if (SteelStrongBroadSwordActive == true)
            {
                GameObject.Find("BroadSword").GetComponent<BroadSword>().Block = true;
                GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("SteelStrongBroadSwordBlock", true);
            }
            //common axes
            if (WoodWeakCommonAxeActive == true)
            {
                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Block = true;
                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("WoodWeakCommonAxeBlock", true);
            }
            if (WoodMediumCommonAxeActive == true)
            {
                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Block = true;
                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("WoodMediumCommonAxeBlock", true);
            }
            if (WoodStrongCommonAxeActive == true)
            {
                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Block = true;
                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("WoodStrongCommonAxeBlock", true);
            }
            if (IronWeakCommonAxeActive == true)
            {
                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Block = true;
                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("IronWeakCommonAxeBlock", true);
            }
            if (IronMediumCommonAxeActive == true)
            {
                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Block = true;
                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("IronMediumCommonAxeBlock", true);
            }
            if (IronStrongCommonAxeActive == true)
            {
                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Block = true;
                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("IronStrongCommonAxeBlock", true);
            }
            if (SteelWeakCommonAxeActive == true)
            {
                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Block = true;
                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("SteelWeakCommonAxeBlock", true);
            }
            if (SteelMediumCommonAxeActive == true)
            {
                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Block = true;
                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("SteelMediumCommonAxeBlock", true);
            }
            if (SteelStrongCommonAxeActive == true)
            {
                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Block = true;
                GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("SteelStrongCommonAxeBlock", true);
            }
            //battle axes
            if (WoodWeakBattleAxeActive == true)
            {
                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Block = true;
                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("WoodWeakBattleAxeBlock", true);
            }
            if (WoodMediumBattleAxeActive == true)
            {
                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Block = true;
                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("WoodMediumBattleAxeBlock", true);
            }
            if (WoodStrongBattleAxeActive == true)
            {
                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Block = true;
                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("WoodStrongBattleAxeBlock", true);
            }
            if (IronWeakBattleAxeActive == true)
            {
                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Block = true;
                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("IronWeakBattleAxeBlock", true);
            }
            if (IronMediumBattleAxeActive == true)
            {
                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Block = true;
                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("IronMediumBattleAxeBlock", true);
            }
            if (IronStrongBattleAxeActive == true)
            {
                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Block = true;
                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("IronStrongBattleAxeBlock", true);
            }
            if (SteelWeakBattleAxeActive == true)
            {
                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Block = true;
                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("SteelWeakBattleAxeBlock", true);
            }
            if (SteelMediumBattleAxeActive == true)
            {
                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Block = true;
                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("SteelMediumBattleAxeBlock", true);
            }
            if (SteelStrongBattleAxeActive == true)
            {
                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Block = true;
                GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("SteelStrongBattleAxeBlock", true);
            }
            //war axes
            if (WoodWeakWarAxeActive == true)
            {
                GameObject.Find("WarAxe").GetComponent<WarAxe>().Block = true;
                GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("WoodWeakWarAxeBlock", true);
            }
            if (WoodMediumWarAxeActive == true)
            {
                GameObject.Find("WarAxe").GetComponent<WarAxe>().Block = true;
                GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("WoodMediumWarAxeBlock", true);
            }
            if (WoodStrongWarAxeActive == true)
            {
                GameObject.Find("WarAxe").GetComponent<WarAxe>().Block = true;
                GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("WoodStrongWarAxeBlock", true);
            }
            if (IronWeakWarAxeActive == true)
            {
                GameObject.Find("WarAxe").GetComponent<WarAxe>().Block = true;
                GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("IronWeakWarAxeBlock", true);
            }
            if (IronMediumWarAxeActive == true)
            {
                GameObject.Find("WarAxe").GetComponent<WarAxe>().Block = true;
                GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("IronMediumWarAxeBlock", true);
            }
            if (IronStrongWarAxeActive == true)
            {
                GameObject.Find("WarAxe").GetComponent<WarAxe>().Block = true;
                GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("IronStrongWarAxeBlock", true);
            }
            if (SteelWeakWarAxeActive == true)
            {
                GameObject.Find("WarAxe").GetComponent<WarAxe>().Block = true;
                GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("SteelWeakWarAxeBlock", true);
            }
            if (SteelMediumWarAxeActive == true)
            {
                GameObject.Find("WarAxe").GetComponent<WarAxe>().Block = true;
                GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("SteelMediumWarAxeBlock", true);
            }
            if (SteelStrongWarAxeActive == true)
            {
                GameObject.Find("WarAxe").GetComponent<WarAxe>().Block = true;
                GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("SteelStrongWarAxeBlock", true);
            }
        }           
    }

    void SetRespawnX(float setx)
    {
        RespawnPlayerXPos = setx;
    }

    void SetRespawnY(float sety)
    {
        RespawnPlayerYPos = sety;
    }

    public void DamagePlayer(float damage)
    {
        float ModifiedDamage = damage * DamageAbsorb;
        float ActualDamage = ModifiedDamage / 100;
        if (Blocking == false)
        {
            var player = GameObject.Find("KP");
            PlayerCurrentHealth = PlayerCurrentHealth - ActualDamage;
            GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetHealthUI(PlayerCurrentHealth, 100);
            if (PlayerCurrentHealth <= 0)
            {
                player.transform.position = new Vector3(RespawnPlayerXPos, RespawnPlayerYPos, RespawnPlayerZPos);
                PlayerCurrentHealth = 100;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetHealthUI(PlayerCurrentHealth, 100);
                PlayerDeaths = PlayerDeaths + 1;
            }
        }  
    }

    public void ChangeCoins(int coins) {
        Coins = Coins + coins;
        GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetCoinsUI(Coins);
    }

    public void ChangeWeapon(int NewWeapon, bool Next) {
         CurrentWeapon = NewWeapon;

         NoWeaponActive = false;

         WoodWeakLesserSwordActive = false;
         WoodMediumLesserSwordActive = false;
         WoodStrongLesserSwordActive = false;
         IronWeakLesserSwordActive = false;
         IronMediumLesserSwordActive = false;
         IronStrongLesserSwordActive = false;
         SteelWeakLesserSwordActive = false;
         SteelMediumLesserSwordActive = false;
         SteelStrongLesserSwordActive = false;

         WoodWeakGreatSwordActive = false;
         WoodMediumGreatSwordActive = false;
         WoodStrongGreatSwordActive = false;
         IronWeakGreatSwordActive = false;
         IronMediumGreatSwordActive = false;
         IronStrongGreatSwordActive = false;
         SteelWeakGreatSwordActive = false;
         SteelMediumGreatSwordActive = false;
         SteelStrongGreatSwordActive = false;

         WoodWeakBroadSwordActive = false;
         WoodMediumBroadSwordActive = false;
         WoodStrongBroadSwordActive = false;
         IronWeakBroadSwordActive = false;
         IronMediumBroadSwordActive = false;
         IronStrongBroadSwordActive = false;
         SteelWeakBroadSwordActive = false;
         SteelMediumBroadSwordActive = false;
         SteelStrongBroadSwordActive = false;

         WoodWeakCommonAxeActive = false;
         WoodMediumCommonAxeActive = false;
         WoodStrongCommonAxeActive = false;
         IronWeakCommonAxeActive = false;
         IronMediumCommonAxeActive = false;
         IronStrongCommonAxeActive = false;
         SteelWeakCommonAxeActive = false;
         SteelMediumCommonAxeActive = false;
         SteelStrongCommonAxeActive = false;

         WoodWeakBattleAxeActive = false;
         WoodMediumBattleAxeActive = false;
         WoodStrongBattleAxeActive = false;
         IronWeakBattleAxeActive = false;
         IronMediumBattleAxeActive = false;
         IronStrongBattleAxeActive = false;
         SteelWeakBattleAxeActive = false;
         SteelMediumBattleAxeActive = false;
         SteelStrongBattleAxeActive = false;

         WoodWeakWarAxeActive = false;
         WoodMediumWarAxeActive = false;
         WoodStrongWarAxeActive = false;
         IronWeakWarAxeActive = false;
         IronMediumWarAxeActive = false;
         IronStrongWarAxeActive = false;
         SteelWeakWarAxeActive = false;
         SteelMediumWarAxeActive = false;
         SteelStrongWarAxeActive = false;

        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("NoWeapon", false);

        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodWeakLesserSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodMediumLesserSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodStrongLesserSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronWeakLesserSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronMediumLesserSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronStrongLesserSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelWeakLesserSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelMediumLesserSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelStrongLesserSword", false);

        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodWeakGreatSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodMediumGreatSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodStrongGreatSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronWeakGreatSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronMediumGreatSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronStrongGreatSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelWeakGreatSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelMediumGreatSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelStrongGreatSword", false);

        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodWeakBroadSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodMediumBroadSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodStrongBroadSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronWeakBroadSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronMediumBroadSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronStrongBroadSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelWeakBroadSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelMediumBroadSword", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelStrongBroadSword", false);

        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodWeakCommonAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodMediumCommonAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodStrongCommonAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronWeakCommonAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronMediumCommonAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronStrongCommonAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelWeakCommonAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelMediumCommonAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelStrongCommonAxe", false);

        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodWeakBattleAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodMediumBattleAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodStrongBattleAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronWeakBattleAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronMediumBattleAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronStrongBattleAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelWeakBattleAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelMediumBattleAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelStrongBattleAxe", false);

        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodWeakWarAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodMediumWarAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodStrongWarAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronWeakWarAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronMediumWarAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronStrongWarAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelWeakWarAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelMediumWarAxe", false);
        GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelStrongWarAxe", false);

        if (CurrentWeapon == 0) {
            GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("NO WEAPON");
            GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("NoWeapon", true);
            NoWeaponActive = true;
        }
        //lesser swords
        if (CurrentWeapon == 1)
        {
            if (WoodWeakLesserSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("WOOD WEAK LESSER SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodWeakLesserSword", true);
                WoodWeakLesserSwordActive = true;
            }
            if (WoodWeakLesserSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 2)
        {
            if (WoodMediumLesserSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("WOOD MEDIUM LESSER SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodMediumLesserSword", true);
                WoodMediumLesserSwordActive = true;
            }
            if (WoodMediumLesserSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 3)
        {
            if (WoodStrongLesserSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("WOOD STRONG LESSER SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodStrongLesserSword", true);
                WoodStrongLesserSwordActive = true;
            }
            if (WoodStrongLesserSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 4)
        {
            if (IronWeakLesserSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("IRON WEAK LESSER SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronWeakLesserSword", true);
                IronWeakLesserSwordActive = true;
            }
            if (IronWeakLesserSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 5)
        {
            if (IronMediumLesserSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("IRON MEDIUM LESSER SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronMediumLesserSword", true);
                IronMediumLesserSwordActive = true;
            }
            if (IronMediumLesserSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 6)
        {
            if (IronStrongLesserSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("IRON STRONG LESSER SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronStrongLesserSword", true);
                IronStrongLesserSwordActive = true;
            }
            if (IronStrongLesserSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 7)
        {
            if (SteelWeakLesserSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("STEEL WEAK LESSER SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelWeakLesserSword", true);
                SteelWeakLesserSwordActive = true;
            }
            if (SteelWeakLesserSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 8)
        {
            if (SteelMediumLesserSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("STEEL MEDIUM LESSER SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelMediumLesserSword", true);
                SteelMediumLesserSwordActive = true;
            }
            if (SteelMediumLesserSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 9)
        {
            if (SteelStrongLesserSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("STEEL STRONG LESSER SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelStrongLesserSword", true);
                SteelStrongLesserSwordActive = true;
            }
            if (SteelStrongLesserSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        //great swords
        if (CurrentWeapon == 10)
        {
            if (WoodWeakGreatSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("WOOD WEAK GREAT SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodWeakGreatSword", true);
                WoodWeakGreatSwordActive = true;
            }
            if (WoodWeakGreatSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 11)
        {
            if (WoodMediumGreatSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("WOOD MEDIUM GREAT SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodMediumGreatSword", true);
                WoodMediumGreatSwordActive = true;
            }
            if (WoodMediumGreatSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 12)
        {
            if (WoodStrongGreatSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("WOOD STRONG GREAT SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodStrongGreatSword", true);
                WoodStrongGreatSwordActive = true;
            }
            if (WoodStrongGreatSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 13)
        {
            if (IronWeakGreatSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("IRON WEAK GREAT SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronWeakGreatSword", true);
                IronWeakGreatSwordActive = true;
            }
            if (IronWeakGreatSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 14)
        {
            if (IronMediumGreatSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("IRON MEDIUM GREAT SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronMediumGreatSword", true);
                IronMediumGreatSwordActive = true;
            }
            if (IronMediumGreatSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 15)
        {
            if (IronStrongGreatSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("IRON STRONG GREAT SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronStrongGreatSword", true);
                IronStrongGreatSwordActive = true;
            }
            if (IronStrongGreatSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 16)
        {
            if (SteelWeakGreatSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("STEEL WEAK GREAT SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelWeakGreatSword", true);
                SteelWeakGreatSwordActive = true;
            }
            if (SteelWeakGreatSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 17)
        {
            if (SteelMediumGreatSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("STEEL MEDIUM GREAT SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelMediumGreatSword", true);
                SteelMediumGreatSwordActive = true;
            }
            if (SteelMediumGreatSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 18)
        {
            if (SteelStrongGreatSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("STEEL STRONG GREAT SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelStrongGreatSword", true);
                SteelStrongGreatSwordActive = true;
            }
            if (SteelStrongGreatSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        //broad swords
        if (CurrentWeapon == 19)
        {
            if (WoodWeakBroadSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("WOOD WEAK BROAD SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodWeakBroadSword", true);
                WoodWeakBroadSwordActive = true;
            }
            if (WoodWeakBroadSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 20)
        {
            if (WoodMediumBroadSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("WOOD MEDIUM BROAD SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodMediumBroadSword", true);
                WoodMediumBroadSwordActive = true;
            }
            if (WoodMediumBroadSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 21)
        {
            if (WoodStrongBroadSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("WOOD STRONG BROAD SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodStrongBroadSword", true);
                WoodStrongBroadSwordActive = true;
            }
            if (WoodStrongBroadSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 22)
        {
            if (IronWeakBroadSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("IRON WEAK BROAD SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronWeakBroadSword", true);
                IronWeakBroadSwordActive = true;
            }
            if (IronWeakBroadSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 23)
        {
            if (IronMediumBroadSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("IRON MEDIUM BROAD SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronMediumBroadSword", true);
                IronMediumBroadSwordActive = true;
            }
            if (IronMediumBroadSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 24)
        {
            if (IronStrongBroadSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("IRON STRONG BROAD SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronStrongBroadSword", true);
                IronStrongBroadSwordActive = true;
            }
            if (IronStrongBroadSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 25)
        {
            if (SteelWeakBroadSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("STEEL WEAK BROAD SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelWeakBroadSword", true);
                SteelWeakBroadSwordActive = true;
            }
            if (SteelWeakBroadSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 26)
        {
            if (SteelMediumBroadSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("STEEL MEDIUM BROAD SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelMediumBroadSword", true);
                SteelMediumBroadSwordActive = true;
            }
            if (SteelMediumBroadSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 27)
        {
            if (SteelStrongBroadSwordBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("STEEL STRONG BROAD SWORD");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelStrongBroadSword", true);
                SteelStrongBroadSwordActive = true;
            }
            if (SteelStrongBroadSwordBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        //common axes
        if (CurrentWeapon == 28)
        {
            if (WoodWeakCommonAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("WOOD WEAK COMMON AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodWeakCommonAxe", true);
                WoodWeakCommonAxeActive = true;
            }
            if (WoodWeakCommonAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 29)
        {
            if (WoodMediumCommonAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("WOOD MEDIUM COMMON AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodMediumCommonAxe", true);
                WoodMediumCommonAxeActive = true;
            }
            if (WoodMediumCommonAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 30)
        {
            if (WoodStrongCommonAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("WOOD STRONG COMMON AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodStrongCommonAxe", true);
                WoodStrongCommonAxeActive = true;
            }
            if (WoodStrongCommonAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 31)
        {
            if (IronWeakCommonAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("IRON WEAK COMMON AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronWeakCommonAxe", true);
                IronWeakCommonAxeActive = true;
            }
            if (IronWeakCommonAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 32)
        {
            if (IronMediumCommonAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("IRON MEDIUM COMMON AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronMediumCommonAxe", true);
                IronMediumCommonAxeActive = true;
            }
            if (IronMediumCommonAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 33)
        {
            if (IronStrongCommonAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("IRON STRONG COMMON AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronStrongCommonAxe", true);
                IronStrongCommonAxeActive = true;
            }
            if (IronStrongCommonAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 34)
        {
            if (SteelWeakCommonAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("STEEL WEAK COMMON AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelWeakCommonAxe", true);
                SteelWeakCommonAxeActive = true;
            }
            if (SteelWeakCommonAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 35)
        {
            if (SteelMediumCommonAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("STEEL MEDIUM COMMON AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelMediumCommonAxe", true);
                SteelMediumCommonAxeActive = true;
            }
            if (SteelMediumCommonAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 36)
        {
            if (SteelStrongCommonAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("STEEL STRONG COMMON AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelStrongCommonAxe", true);
                SteelStrongCommonAxeActive = true;
            }
            if (SteelStrongCommonAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        //battle axes
        if (CurrentWeapon == 37)
        {
            if (WoodWeakBattleAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("WOOD WEAK BATTLE AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodWeakBattleAxe", true);
                WoodWeakBattleAxeActive = true;
            }
            if (WoodWeakBattleAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 38)
        {
            if (WoodMediumBattleAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("WOOD MEDIUM BATTLE AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodMediumBattleAxe", true);
                WoodMediumBattleAxeActive = true;
            }
            if (WoodMediumBattleAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 39)
        {
            if (WoodStrongBattleAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("WOOD STRONG BATTLE AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodStrongBattleAxe", true);
                WoodStrongBattleAxeActive = true;
            }
            if (WoodStrongBattleAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 40)
        {
            if (IronWeakBattleAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("IRON WEAK BATTLE AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronWeakBattleAxe", true);
                IronWeakBattleAxeActive = true;
            }
            if (IronWeakBattleAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 41)
        {
            if (IronMediumBattleAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("IRON MEDIUM BATTLE AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronMediumBattleAxe", true);
                IronMediumBattleAxeActive = true;
            }
            if (IronMediumBattleAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 42)
        {
            if (IronStrongBattleAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("IRON STRONG BATTLE AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronStrongBattleAxe", true);
                IronStrongBattleAxeActive = true;
            }
            if (IronStrongBattleAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 43)
        {
            if (SteelWeakBattleAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("STEEL WEAK BATTLE AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelWeakBattleAxe", true);
                SteelWeakBattleAxeActive = true;
            }
            if (SteelWeakBattleAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 44)
        {
            if (SteelMediumBattleAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("STEEL MEDIUM BATTLE AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelMediumBattleAxe", true);
                SteelMediumBattleAxeActive = true;
            }
            if (SteelMediumBattleAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 45)
        {
            if (SteelStrongBattleAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("STEEL STRONG BATTLE AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelStrongBattleAxe", true);
                SteelStrongBattleAxeActive = true;
            }
            if (SteelStrongBattleAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        //war axes
        if (CurrentWeapon == 46)
        {
            if (WoodWeakWarAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("WOOD WEAK WAR AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodWeakWarAxe", true);
                WoodWeakWarAxeActive = true;
            }
            if (WoodWeakWarAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 47)
        {
            if (WoodMediumWarAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("WOOD MEDIUM WAR AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodMediumWarAxe", true);
                WoodMediumWarAxeActive = true;
            }
            if (WoodMediumWarAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 48)
        {
            if (WoodStrongWarAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("WOOD STRONG WAR AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("WoodStrongWarAxe", true);
                WoodStrongWarAxeActive = true;
            }
            if (WoodStrongWarAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 49)
        {
            if (IronWeakWarAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("IRON WEAK WAR AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronWeakWarAxe", true);
                IronWeakWarAxeActive = true;
            }
            if (IronWeakWarAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 50)
        {
            if (IronMediumWarAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("IRON MEDIUM WAR AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronMediumWarAxe", true);
                IronMediumWarAxeActive = true;
            }
            if (IronMediumWarAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 51)
        {
            if (IronStrongWarAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("IRON STRONG WAR AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("IronStrongWarAxe", true);
                IronStrongWarAxeActive = true;
            }
            if (IronStrongWarAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 52)
        {
            if (SteelWeakWarAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("STEEL WEAK WAR AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelWeakWarAxe", true);
                SteelWeakWarAxeActive = true;
            }
            if (SteelWeakWarAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 53)
        {
            if (SteelMediumWarAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("STEEL MEDIUM WAR AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelMediumWarAxe", true);
                SteelMediumWarAxeActive = true;
            }
            if (SteelMediumWarAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon == 54)
        {
            if (SteelStrongWarAxeBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponText("STEEL STRONG WAR AXE");
                GameObject.Find("WeaponSelected").GetComponent<Animator>().SetBool("SteelStrongWarAxe", true);
                SteelStrongWarAxeActive = true;
            }
            if (SteelStrongWarAxeBought == false)
            {
                if (Next == true)
                {
                    ChangeWeapon(CurrentWeapon + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeapon(CurrentWeapon - 1, false);
                }
            }
        }
        if (CurrentWeapon < 0) {
            ChangeWeapon(0, true);
        }
        if (CurrentWeapon > 54) //esures can't go past max
        {
            ChangeWeapon(54, false);
        }
    }
    public void ChangeArmor(int NewArmor, bool Next) {
        CurrentArmor = NewArmor;

        NoArmorActive = false;
        LeatherArmorActive = false;
        IronArmorActive = false;
        SteelArmorActive = false;

        NoArmorActive = false;
        m_Anim.SetBool("NoArmor", false);
        GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", false);
        GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", false);
        GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", false);

        LeatherArmorActive = false;
        m_Anim.SetBool("LeatherArmor", false);
        GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", false);
        GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", false);
        GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", false);

        IronArmorActive = false;
        m_Anim.SetBool("IronArmor", false);
        GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", false);
        GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", false);
        GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", false);

        SteelArmorActive = false;
        m_Anim.SetBool("SteelArmor", false);
        GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", false);
        GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", false);
        GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", false);

        GameObject.Find("ArmorSelected").GetComponent<Animator>().SetBool("NoArmor", false);
        GameObject.Find("ArmorSelected").GetComponent<Animator>().SetBool("LeatherArmor", false);
        GameObject.Find("ArmorSelected").GetComponent<Animator>().SetBool("IronArmor", false);
        GameObject.Find("ArmorSelected").GetComponent<Animator>().SetBool("SteelArmor", false);

        if (CurrentArmor == 0)
        {
            GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetArmorText("NO ARMOR");
            GameObject.Find("ArmorSelected").GetComponent<Animator>().SetBool("NoArmor", true);
            DamageAbsorb = 100;
            NoArmorActive = true;
            m_Anim.SetBool("NoArmor", true);
            GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("NoArmor", true);
            GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("NoArmor", true);
            GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("NoArmor", true);
        }
        if (CurrentArmor == 1)
        {
            if (LeatherArmorBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetArmorText("LEATHER ARMOR");
                GameObject.Find("ArmorSelected").GetComponent<Animator>().SetBool("LeatherArmor", true);
                DamageAbsorb = 80;
                LeatherArmorActive = true;
                m_Anim.SetBool("LeatherArmor", true);
                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("LeatherArmor", true);
                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("LeatherArmor", true);
                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("LeatherArmor", true);
            }
            if (LeatherArmorBought == false)
            {
                if (Next == true)
                {
                    ChangeArmor(CurrentArmor + 1, true);
                }
                if (Next == false)
                {
                    ChangeArmor(CurrentArmor - 1, false);
                }
            }
        }
        if (CurrentArmor == 2)
        {
            if (IronArmorBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetArmorText("IRON ARMOR");
                GameObject.Find("ArmorSelected").GetComponent<Animator>().SetBool("IronArmor", true);
                DamageAbsorb = 60;
                IronArmorActive = true;
                m_Anim.SetBool("IronArmor", true);
                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("IronArmor", true);
                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("IronArmor", true);
                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("IronArmor", true);
            }
            if (IronArmorBought == false)
            {
                if (Next == true)
                {
                    ChangeArmor(CurrentArmor + 1, true);
                }
                if (Next == false)
                {
                    ChangeArmor(CurrentArmor - 1, false);
                }
            }
        }
        if (CurrentArmor == 3)
        {
            if (SteelArmorBought == true)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetArmorText("STEEL ARMOR");
                GameObject.Find("ArmorSelected").GetComponent<Animator>().SetBool("SteelArmor", true);
                DamageAbsorb = 40;
                SteelArmorActive = true;
                m_Anim.SetBool("SteelArmor", true);
                GameObject.Find("KP_Arm").GetComponent<ArmSwing>().m_Anim.SetBool("SteelArmor", true);
                GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("SteelArmor", true);
                GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("SteelArmor", true);
            }
            if (SteelArmorBought == false)
            {
                if (Next == true)
                {
                    ChangeArmor(CurrentArmor + 1, true);
                }
                if (Next == false)
                {
                    ChangeArmor(CurrentArmor - 1, false);
                }
            }
        }
        if (CurrentArmor < 0) {
            ChangeArmor(0, true);
        }
        if (CurrentArmor > 3) //esures can't go past max
        {
            ChangeArmor(3, false);
        }
    }

    public void ChangeWeaponBuy(int NewWeapon, bool Next) {
        CurrentWeaponBuy = NewWeapon;

        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("NoWeapon", false);

        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodWeakLesserSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodMediumLesserSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodStrongLesserSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronWeakLesserSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronMediumLesserSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronStrongLesserSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelWeakLesserSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelMediumLesserSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelStrongLesserSword", false);

        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodWeakGreatSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodMediumGreatSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodStrongGreatSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronWeakGreatSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronMediumGreatSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronStrongGreatSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelWeakGreatSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelMediumGreatSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelStrongGreatSword", false);

        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodWeakBroadSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodMediumBroadSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodStrongBroadSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronWeakBroadSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronMediumBroadSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronStrongBroadSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelWeakBroadSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelMediumBroadSword", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelStrongBroadSword", false);

        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodWeakCommonAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodMediumCommonAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodStrongCommonAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronWeakCommonAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronMediumCommonAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronStrongCommonAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelWeakCommonAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelMediumCommonAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelStrongCommonAxe", false);

        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodWeakBattleAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodMediumBattleAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodStrongBattleAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronWeakBattleAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronMediumBattleAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronStrongBattleAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelWeakBattleAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelMediumBattleAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelStrongBattleAxe", false);

        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodWeakWarAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodMediumWarAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodStrongWarAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronWeakWarAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronMediumWarAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronStrongWarAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelWeakWarAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelMediumWarAxe", false);
        GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelStrongWarAxe", false);
      
        //lesser swords
        if (CurrentWeaponBuy == 1)
        {
            if (WoodWeakLesserSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (WoodWeakLesserSwordBought == false)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("WOOD WEAK LESSER SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodWeakLesserSword", true);
                WeaponPrice = 5;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 2)
        {
            if (WoodMediumLesserSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (WoodMediumLesserSwordBought == false)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("WOOD MEDIUM LESSER SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodMediumLesserSword", true);
                WeaponPrice = 10;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 3)
        {
            if (WoodStrongLesserSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (WoodStrongLesserSwordBought == false)
            {              
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("WOOD STRONG LESSER SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodStrongLesserSword", true);
                WeaponPrice = 15;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 4)
        {
            if (IronWeakLesserSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (IronWeakLesserSwordBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("IRON WEAK LESSER SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronWeakLesserSword", true);
                WeaponPrice = 20;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 5)
        {
            if (IronMediumLesserSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (IronMediumLesserSwordBought == false)
            {               
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("IRON MEDIUM LESSER SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronMediumLesserSword", true);
                WeaponPrice = 25;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 6)
        {
            if (IronStrongLesserSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (IronStrongLesserSwordBought == false)
            {               
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("IRON STRONG LESSER SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronStrongLesserSword", true);
                WeaponPrice = 30;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 7)
        {
            if (SteelWeakLesserSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (SteelWeakLesserSwordBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("STEEL WEAK LESSER SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelWeakLesserSword", true);
                WeaponPrice = 35;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 8)
        {
            if (SteelMediumLesserSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (SteelMediumLesserSwordBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("STEEL MEDIUM LESSER SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelMediumLesserSword", true);
                WeaponPrice = 40;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 9)
        {
            if (SteelStrongLesserSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (SteelStrongLesserSwordBought == false)
            {               
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("STEEL STRONG LESSER SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelStrongLesserSword", true);
                WeaponPrice = 45;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        //great swords
        if (CurrentWeaponBuy == 10)
        {
            if (WoodWeakGreatSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (WoodWeakGreatSwordBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("WOOD WEAK GREAT SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodWeakGreatSword", true);
                WeaponPrice = 50;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 11)
        {
            if (WoodMediumGreatSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (WoodMediumGreatSwordBought == false)
            {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("WOOD MEDIUM GREAT SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodMediumGreatSword", true);
                WeaponPrice = 55;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 12)
        {
            if (WoodStrongGreatSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (WoodStrongGreatSwordBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("WOOD STRONG GREAT SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodStrongGreatSword", true);
                WeaponPrice = 60;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 13)
        {
            if (IronWeakGreatSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (IronWeakGreatSwordBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("IRON WEAK GREAT SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronWeakGreatSword", true);
                WeaponPrice = 65;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 14)
        {
            if (IronMediumGreatSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (IronMediumGreatSwordBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("IRON MEDIUM GREAT SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronMediumGreatSword", true);
                WeaponPrice = 70;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 15)
        {
            if (IronStrongGreatSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (IronStrongGreatSwordBought == false)
            {               
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("IRON STRONG GREAT SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronStrongGreatSword", true);
                WeaponPrice = 75;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 16)
        {
            if (SteelWeakGreatSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (SteelWeakGreatSwordBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("STEEL WEAK GREAT SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelWeakGreatSword", true);
                WeaponPrice = 80;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 17)
        {
            if (SteelMediumGreatSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (SteelMediumGreatSwordBought == false)
            {               
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("STEEL MEDIUM GREAT SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelMediumGreatSword", true);
                WeaponPrice = 85;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 18)
        {
            if (SteelStrongGreatSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (SteelStrongGreatSwordBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("STEEL STRONG GREAT SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelStrongGreatSword", true);
                WeaponPrice = 90;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        //broad swords
        if (CurrentWeaponBuy == 19)
        {
            if (WoodWeakBroadSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (WoodWeakBroadSwordBought == false)
            {               
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("WOOD WEAK BROAD SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodWeakBroadSword", true);
                WeaponPrice = 95;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 20)
        {
            if (WoodMediumBroadSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (WoodMediumBroadSwordBought == false)
            {               
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("WOOD MEDIUM BROAD SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodMediumBroadSword", true);
                WeaponPrice = 100;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 21)
        {
            if (WoodStrongBroadSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (WoodStrongBroadSwordBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("WOOD STRONG BROAD SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodStrongBroadSword", true);
                WeaponPrice = 105;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 22)
        {
            if (IronWeakBroadSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (IronWeakBroadSwordBought == false)
            {               
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("IRON WEAK BROAD SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronWeakBroadSword", true);
                WeaponPrice = 110;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 23)
        {
            if (IronMediumBroadSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (IronMediumBroadSwordBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("IRON MEDIUM BROAD SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronMediumBroadSword", true);
                WeaponPrice = 115;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 24)
        {
            if (IronStrongBroadSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (IronStrongBroadSwordBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("IRON STRONG BROAD SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronStrongBroadSword", true);
                WeaponPrice = 120;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 25)
        {
            if (SteelWeakBroadSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (SteelWeakBroadSwordBought == false)
            {               
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("STEEL WEAK BROAD SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelWeakBroadSword", true);
                WeaponPrice = 125;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 26)
        {
            if (SteelMediumBroadSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (SteelMediumBroadSwordBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("STEEL MEDIUM BROAD SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelMediumBroadSword", true);
                WeaponPrice = 130;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 27)
        {
            if (SteelStrongBroadSwordBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (SteelStrongBroadSwordBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("STEEL STRONG BROAD SWORD");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelStrongBroadSword", true);
                WeaponPrice = 135;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        //common axes
        if (CurrentWeaponBuy == 28)
        {
            if (WoodWeakCommonAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (WoodWeakCommonAxeBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("WOOD WEAK COMMON AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodWeakCommonAxe", true);
                WeaponPrice = 140;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 29)
        {
            if (WoodMediumCommonAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (WoodMediumCommonAxeBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("WOOD MEDIUM COMMON AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodMediumCommonAxe", true);
                WeaponPrice = 145;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 30)
        {
            if (WoodStrongCommonAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (WoodStrongCommonAxeBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("WOOD STRONG COMMON AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodStrongCommonAxe", true);
                WeaponPrice = 150;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 31)
        {
            if (IronWeakCommonAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (IronWeakCommonAxeBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("IRON WEAK COMMON AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronWeakCommonAxe", true);
                WeaponPrice = 155;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 32)
        {
            if (IronMediumCommonAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (IronMediumCommonAxeBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("IRON MEDIUM COMMON AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronMediumCommonAxe", true);
                WeaponPrice = 160;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 33)
        {
            if (IronStrongCommonAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (IronStrongCommonAxeBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("IRON STRONG COMMON AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronStrongCommonAxe", true);
                WeaponPrice = 165;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 34)
        {
            if (SteelWeakCommonAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (SteelWeakCommonAxeBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("STEEL WEAK COMMON AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelWeakCommonAxe", true);
                WeaponPrice = 170;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 35)
        {
            if (SteelMediumCommonAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (SteelMediumCommonAxeBought == false)
            {               
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("STEEL MEDIUM COMMON AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelMediumCommonAxe", true);
                WeaponPrice = 175;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 36)
        {
            if (SteelStrongCommonAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (SteelStrongCommonAxeBought == false)
            {               
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("STEEL STRONG COMMON AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelStrongCommonAxe", true);
                WeaponPrice = 180;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        //battle axes
        if (CurrentWeaponBuy == 37)
        {
            if (WoodWeakBattleAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (WoodWeakBattleAxeBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("WOOD WEAK BATTLE AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodWeakBattleAxe", true);
                WeaponPrice = 185;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 38)
        {
            if (WoodMediumBattleAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (WoodMediumBattleAxeBought == false)
            {               
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("WOOD MEDIUM BATTLE AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodMediumBattleAxe", true);
                WeaponPrice = 190;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 39)
        {
            if (WoodStrongBattleAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (WoodStrongBattleAxeBought == false)
            {               
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("WOOD STRONG BATTLE AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodStrongBattleAxe", true);
                WeaponPrice = 195;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 40)
        {
            if (IronWeakBattleAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (IronWeakBattleAxeBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("IRON WEAK BATTLE AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronWeakBattleAxe", true);
                WeaponPrice = 200;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 41)
        {
            if (IronMediumBattleAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (IronMediumBattleAxeBought == false)
            {               
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("IRON MEDIUM BATTLE AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronMediumBattleAxe", true);
                WeaponPrice = 205;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 42)
        {
            if (IronStrongBattleAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (IronStrongBattleAxeBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("IRON STRONG BATTLE AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronStrongBattleAxe", true);
                WeaponPrice = 210;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 43)
        {
            if (SteelWeakBattleAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (SteelWeakBattleAxeBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("STEEL WEAK BATTLE AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelWeakBattleAxe", true);
                WeaponPrice = 215;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 44)
        {
            if (SteelMediumBattleAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (SteelMediumBattleAxeBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("STEEL MEDIUM BATTLE AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelMediumBattleAxe", true);
                WeaponPrice = 220;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 45)
        {
            if (SteelStrongBattleAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (SteelStrongBattleAxeBought == false)
            {               
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("STEEL STRONG BATTLE AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelStrongBattleAxe", true);
                WeaponPrice = 225;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        //war axes
        if (CurrentWeaponBuy == 46)
        {
            if (WoodWeakWarAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (WoodWeakWarAxeBought == false)
            {               
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("WOOD WEAK WAR AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodWeakWarAxe", true);
                WeaponPrice = 230;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 47)
        {
            if (WoodMediumWarAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (WoodMediumWarAxeBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("WOOD MEDIUM WAR AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodMediumWarAxe", true);
                WeaponPrice = 235;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 48)
        {
            if (WoodStrongWarAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (WoodStrongWarAxeBought == false)
            {               
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("WOOD STRONG WAR AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("WoodStrongWarAxe", true);
                WeaponPrice = 240;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 49)
        {
            if (IronWeakWarAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (IronWeakWarAxeBought == false)
            {               
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("IRON WEAK WAR AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronWeakWarAxe", true);
                WeaponPrice = 245;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 50)
        {
            if (IronMediumWarAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (IronMediumWarAxeBought == false)
            {              
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("IRON MEDIUM WAR AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronMediumWarAxe", true);
                WeaponPrice = 250;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 51)
        {
            if (IronStrongWarAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (IronStrongWarAxeBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("IRON STRONG WAR AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("IronStrongWarAxe", true);
                WeaponPrice = 255;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 52)
        {
            if (SteelWeakWarAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (SteelWeakWarAxeBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("STEEL WEAK WAR AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelWeakWarAxe", true);
                WeaponPrice = 260;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 53)
        {
            if (SteelMediumWarAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (SteelMediumWarAxeBought == false)
            {                
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("STEEL MEDIUM WAR AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelMediumWarAxe", true);
                WeaponPrice = 265;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (CurrentWeaponBuy == 54)
        {
            if (SteelStrongWarAxeBought == true)
            {
                if (Next == true)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
                }
            }
            if (SteelStrongWarAxeBought == false)
            {               
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("STEEL STRONG WAR AXE");
                GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("SteelStrongWarAxe", true);
                WeaponPrice = 270;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
            }
        }
        if (WeaponsBought == 54)
        {
            GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponBuyText("ALL WEAPONS BOUGHT");
            GameObject.Find("WeaponSelectedBuy").GetComponent<Animator>().SetBool("NoWeapon", true);
            WeaponPrice = 0;
            GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetWeaponPriceText(WeaponPrice);
        }
        else {
            if (CurrentWeaponBuy < 1)
            {
                ChangeWeaponBuy(1, true);
            }
            if (CurrentWeaponBuy > 54) //esures can't go past max
            {
                ChangeWeaponBuy(54, false);
            }
        }      
    }   

    public void ChangeArmorBuy(int NewArmor, bool Next) {
        CurrentArmorBuy = NewArmor;

        GameObject.Find("ArmorSelectedBuy").GetComponent<Animator>().SetBool("NoArmor", false);
        GameObject.Find("ArmorSelectedBuy").GetComponent<Animator>().SetBool("LeatherArmor", false);
        GameObject.Find("ArmorSelectedBuy").GetComponent<Animator>().SetBool("IronArmor", false);
        GameObject.Find("ArmorSelectedBuy").GetComponent<Animator>().SetBool("SteelArmor", false);

        if (CurrentArmorBuy == 0)
        {
            if (LeatherArmorBought == true) {
                if (Next == true)
                {
                    ChangeArmorBuy(CurrentArmorBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeArmorBuy(CurrentArmorBuy - 1, false);
                }
            }
            if (LeatherArmorBought == false) {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetArmorBuyText("LEATHER ARMOR");
                GameObject.Find("ArmorSelectedBuy").GetComponent<Animator>().SetBool("LeatherArmor", true);
                ArmorPrice = 10;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetArmorPriceText(ArmorPrice);
            }
        }
        if (CurrentArmorBuy == 1)
        {
            if (IronArmorBought == true) {
                if (Next == true)
                {
                    ChangeArmorBuy(CurrentArmorBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeArmorBuy(CurrentArmorBuy - 1, false);
                }
            }
            if (IronArmorBought == false) {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetArmorBuyText("IRON ARMOR");
                GameObject.Find("ArmorSelectedBuy").GetComponent<Animator>().SetBool("IronArmor", true);
                ArmorPrice = 25;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetArmorPriceText(ArmorPrice);
            }
        }
        if (CurrentArmorBuy == 2)
        {
            if (SteelArmorBought == true) {
                if (Next == true)
                {
                    ChangeArmorBuy(CurrentArmorBuy + 1, true);
                }
                if (Next == false)
                {
                    ChangeArmorBuy(CurrentArmorBuy - 1, false);
                }
            }
            if (SteelArmorBought == false) {
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetArmorBuyText("STEEL ARMOR");
                GameObject.Find("ArmorSelectedBuy").GetComponent<Animator>().SetBool("SteelArmor", true);
                ArmorPrice = 50;
                GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetArmorPriceText(ArmorPrice);
            }
        }        
        if (ArmorsBought == 3)
        {
            GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetArmorBuyText("ALL ARMORS BOUGHT");
            GameObject.Find("ArmorSelectedBuy").GetComponent<Animator>().SetBool("NoArmor", true);
            ArmorPrice = 0;
            GameObject.Find("UIOverlay").GetComponent<UIOverlay>().SetArmorPriceText(ArmorPrice);
        }
        else {
            if (CurrentArmorBuy < 0)
            {
                ChangeArmorBuy(0, true);
            }
            if (CurrentArmorBuy > 2) //esures can't go past max
            {
                ChangeArmorBuy(2, false);
            }
        }     
    }

    public void NextWeapon() {
        ChangeWeapon(CurrentWeapon + 1, true);
    }

    public void PreviousWeapon()
    {
        ChangeWeapon(CurrentWeapon - 1, false);
    }

    public void NextArmor() {
        ChangeArmor(CurrentArmor + 1, true);
    }

    public void PreviousArmor() {
        ChangeArmor(CurrentArmor - 1, false);
    }

    public void NextWeaponBuy() {
        ChangeWeaponBuy (CurrentWeaponBuy + 1, true);
    }

    public void PreviousWeaponBuy()
    {
        ChangeWeaponBuy(CurrentWeaponBuy - 1, false);
    }

    public void NextArmorBuy()
    {
        ChangeArmorBuy(CurrentArmorBuy + 1, true);
    }

    public void PreviousArmorBuy()
    {
        ChangeArmorBuy(CurrentArmorBuy - 1, false);
    }

    public void BuyWeapon()
    {
        if (BuyMenuOpen == true)
        {
            if (CurrentWeaponBuy == 1)
            {
                if (Coins >= WeaponPrice)
                {
                    WoodWeakLesserSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 2)
            {
                if (Coins >= WeaponPrice)
                {
                    WoodMediumLesserSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 3)
            {
                if (Coins >= WeaponPrice)
                {
                    WoodStrongLesserSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 4)
            {
                if (Coins >= WeaponPrice)
                {
                    IronWeakLesserSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 5)
            {
                if (Coins >= WeaponPrice)
                {
                    IronMediumLesserSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 6)
            {
                if (Coins >= WeaponPrice)
                {
                    IronStrongLesserSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 7)
            {
                if (Coins >= WeaponPrice)
                {
                    SteelWeakLesserSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 8)
            {
                if (Coins >= WeaponPrice)
                {
                    SteelMediumLesserSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 9)
            {
                if (Coins >= WeaponPrice)
                {
                    SteelStrongLesserSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 10)
            {
                if (Coins >= WeaponPrice)
                {
                    WoodWeakGreatSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 11)
            {
                if (Coins >= WeaponPrice)
                {
                    WoodMediumGreatSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 12)
            {
                if (Coins >= WeaponPrice)
                {
                    WoodStrongGreatSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 13)
            {
                if (Coins >= WeaponPrice)
                {
                    IronWeakGreatSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 14)
            {
                if (Coins >= WeaponPrice)
                {
                    IronMediumGreatSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 15)
            {
                if (Coins >= WeaponPrice)
                {
                    IronStrongGreatSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 16)
            {
                if (Coins >= WeaponPrice)
                {
                    SteelWeakGreatSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 17)
            {
                if (Coins >= WeaponPrice)
                {
                    SteelMediumGreatSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 18)
            {
                if (Coins >= WeaponPrice)
                {
                    SteelStrongGreatSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 19)
            {
                if (Coins >= WeaponPrice)
                {
                    WoodWeakBroadSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 20)
            {
                if (Coins >= WeaponPrice)
                {
                    WoodMediumBroadSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 21)
            {
                if (Coins >= WeaponPrice)
                {
                    WoodStrongBroadSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 22)
            {
                if (Coins >= WeaponPrice)
                {
                    IronWeakBroadSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 23)
            {
                if (Coins >= WeaponPrice)
                {
                    IronMediumBroadSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 24)
            {
                if (Coins >= WeaponPrice)
                {
                    IronStrongBroadSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 25)
            {
                if (Coins >= WeaponPrice)
                {
                    SteelWeakBroadSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 26)
            {
                if (Coins >= WeaponPrice)
                {
                    SteelMediumBroadSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 27)
            {
                if (Coins >= WeaponPrice)
                {
                    SteelStrongBroadSwordBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 28)
            {
                if (Coins >= WeaponPrice)
                {
                    WoodWeakCommonAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 29)
            {
                if (Coins >= WeaponPrice)
                {
                    WoodMediumCommonAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 30)
            {
                if (Coins >= WeaponPrice)
                {
                    WoodStrongCommonAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 31)
            {
                if (Coins >= WeaponPrice)
                {
                    IronWeakCommonAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 32)
            {
                if (Coins >= WeaponPrice)
                {
                    IronMediumCommonAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 33)
            {
                if (Coins >= WeaponPrice)
                {
                    IronStrongCommonAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 34)
            {
                if (Coins >= WeaponPrice)
                {
                    SteelWeakCommonAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 35)
            {
                if (Coins >= WeaponPrice)
                {
                    SteelMediumCommonAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 36)
            {
                if (Coins >= WeaponPrice)
                {
                    SteelStrongCommonAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 37)
            {
                if (Coins >= WeaponPrice)
                {
                    WoodWeakBattleAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 38)
            {
                if (Coins >= WeaponPrice)
                {
                    WoodMediumBattleAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 39)
            {
                if (Coins >= WeaponPrice)
                {
                    WoodStrongBattleAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 40)
            {
                if (Coins >= WeaponPrice)
                {
                    IronWeakBattleAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 41)
            {
                if (Coins >= WeaponPrice)
                {
                    IronMediumBattleAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 42)
            {
                if (Coins >= WeaponPrice)
                {
                    IronStrongBattleAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 43)
            {
                if (Coins >= WeaponPrice)
                {
                    SteelWeakBattleAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 44)
            {
                if (Coins >= WeaponPrice)
                {
                    SteelMediumBattleAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 45)
            {
                if (Coins >= WeaponPrice)
                {
                    SteelStrongBattleAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 46)
            {
                if (Coins >= WeaponPrice)
                {
                    WoodWeakWarAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 47)
            {
                if (Coins >= WeaponPrice)
                {
                    WoodMediumWarAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 48)
            {
                if (Coins >= WeaponPrice)
                {
                    WoodStrongWarAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 49)
            {
                if (Coins >= WeaponPrice)
                {
                    IronWeakWarAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 50)
            {
                if (Coins >= WeaponPrice)
                {
                    IronMediumWarAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 51)
            {
                if (Coins >= WeaponPrice)
                {
                    IronStrongWarAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 52)
            {
                if (Coins >= WeaponPrice)
                {
                    SteelWeakWarAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 53)
            {
                if (Coins >= WeaponPrice)
                {
                    SteelMediumWarAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
            if (CurrentWeaponBuy == 54)
            {
                if (Coins >= WeaponPrice)
                {
                    SteelStrongWarAxeBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-WeaponPrice);
                    WeaponsBought = WeaponsBought + 1;
                }
            }
        }
    }

    public void BuyArmor()
    {
        if (BuyMenuOpen == true)
        {
            if (CurrentArmorBuy == 0)
            {
                if (Coins >= ArmorPrice)
                {
                    LeatherArmorBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-ArmorPrice);
                    ArmorsBought = ArmorsBought + 1;
                }
            }
            if (CurrentArmorBuy == 1)
            {
                if (Coins >= ArmorPrice)
                {
                    IronArmorBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-ArmorPrice);
                    ArmorsBought = ArmorsBought + 1;
                }
            }
            if (CurrentArmorBuy == 2)
            {
                if (Coins >= ArmorPrice)
                {
                    SteelArmorBought = true;
                    CloseBuyMenu();
                    ChangeCoins(-ArmorPrice);
                    ArmorsBought = ArmorsBought + 1;
                }
            }
        }
    }

    public void OpenBuyMenu() {       
            if (BuyMenuOpen == false)
            {
                if (InventoryOpen == false)
                {
                    if (GameMenuOpen == false)
                    {
                    BuyMenuWeapon.SetActive(true);
                    BuyMenuItems.SetActive(true);
                    BuyMenuArmor.SetActive(true);
                    BuyMenuCloseButton.SetActive(true);
                    pauseMenuUI.GetComponent<PauseMenuUI>().m_Anim.SetTrigger("BuyMenu");
                    BuyMenuOpen = true;
                    InventoryWeapon.SetActive(false);
                    InventoryItems.SetActive(false);
                    InventoryArmor.SetActive(false);
                    InventoryCloseButton.SetActive(false);
                    QuitButton.SetActive(false);
                    ControlsButton.SetActive(false);
                    InGameMenuCloseButton.SetActive(false);
                    ChangeWeaponBuy(CurrentWeaponBuy, true);
                    ChangeArmorBuy(CurrentArmorBuy, true);
                }
            }
        }        
    }

    public void CloseBuyMenu() {
        if (BuyMenuOpen == true)
        {
            pauseMenuUI.GetComponent<PauseMenuUI>().m_Anim.SetTrigger("None");
            BuyMenuOpen = false;
            BuyMenuWeapon.SetActive(true);
            BuyMenuItems.SetActive(true);
            BuyMenuArmor.SetActive(true);
            BuyMenuCloseButton.SetActive(true);
            InventoryWeapon.SetActive(true);
            InventoryItems.SetActive(true);
            InventoryArmor.SetActive(true);
            InventoryCloseButton.SetActive(true);
            InGameMenuCloseButton.SetActive(true);
            QuitButton.SetActive(true);
            ControlsButton.SetActive(true);
        }
    }

    public void OpenControls() {
        pauseMenuUI.GetComponent<PauseMenuUI>().m_Anim.ResetTrigger("InGameMenu");
        pauseMenuUI.GetComponent<PauseMenuUI>().m_Anim.SetTrigger("Controls");
        QuitButton.SetActive(false);
        ControlsButton.SetActive(false);
    }

    void SetBlockBar(float _cur, float _max)
    {
        float _value = (float)_cur / _max;
        blockBarRect.localScale = new Vector3(_value, blockBarRect.localScale.y, blockBarRect.localScale.z);
    }

    void ReleaseBlock() {

        GameObject.Find("KP_JumpNewArmRight").GetComponent<Animator>().SetBool("Swing", false);
        GameObject.Find("KP_JumpNewArmLeft").GetComponent<Animator>().SetBool("Swing", false);

        m_Anim.SetBool("Swing", false);
        Blocking = false;
        //lesser swords
        if (WoodWeakLesserSwordActive == true)
        {
            GameObject.Find("LesserSword").GetComponent<LesserSword>().Block = false;
            GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("WoodWeakLesserSwordBlock", false);
        }
        if (WoodMediumLesserSwordActive == true)
        {
            GameObject.Find("LesserSword").GetComponent<LesserSword>().Block = false;
            GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("WoodMediumLesserSwordBlock", false);
        }
        if (WoodStrongLesserSwordActive == true)
        {
            GameObject.Find("LesserSword").GetComponent<LesserSword>().Block = false;
            GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("WoodStrongLesserSwordBlock", false);
        }
        if (IronWeakLesserSwordActive == true)
        {
            GameObject.Find("LesserSword").GetComponent<LesserSword>().Block = false;
            GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("IronWeakLesserSwordBlock", false);
        }
        if (IronMediumLesserSwordActive == true)
        {
            GameObject.Find("LesserSword").GetComponent<LesserSword>().Block = false;
            GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("IronMediumLesserSwordBlock", false);
        }
        if (IronStrongLesserSwordActive == true)
        {
            GameObject.Find("LesserSword").GetComponent<LesserSword>().Block = false;
            GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("IronStrongLesserSwordBlock", false);
        }
        if (SteelWeakLesserSwordActive == true)
        {
            GameObject.Find("LesserSword").GetComponent<LesserSword>().Block = false;
            GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("SteelWeakLesserSwordBlock", false);
        }
        if (SteelMediumLesserSwordActive == true)
        {
            GameObject.Find("LesserSword").GetComponent<LesserSword>().Block = false;
            GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("SteelMediumLesserSwordBlock", false);
        }
        if (SteelStrongLesserSwordActive == true)
        {
            GameObject.Find("LesserSword").GetComponent<LesserSword>().Block = false;
            GameObject.Find("LesserSword").GetComponent<LesserSword>().m_Anim.SetBool("SteelStrongLesserSwordBlock", false);
        }
        //great swords
        if (WoodWeakGreatSwordActive == true)
        {
            GameObject.Find("GreatSword").GetComponent<GreatSword>().Block = false;
            GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("WoodWeakGreatSwordBlock", false);
        }
        if (WoodMediumGreatSwordActive == true)
        {
            GameObject.Find("GreatSword").GetComponent<GreatSword>().Block = false;
            GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("WoodMediumGreatSwordBlock", false);
        }
        if (WoodStrongGreatSwordActive == true)
        {
            GameObject.Find("GreatSword").GetComponent<GreatSword>().Block = false;
            GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("WoodStrongGreatSwordBlock", false);
        }
        if (IronWeakGreatSwordActive == true)
        {
            GameObject.Find("GreatSword").GetComponent<GreatSword>().Block = false;
            GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("IronWeakGreatSwordBlock", false);
        }
        if (IronMediumGreatSwordActive == true)
        {
            GameObject.Find("GreatSword").GetComponent<GreatSword>().Block = false;
            GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("IronMediumGreatSwordBlock", false);
        }
        if (IronStrongGreatSwordActive == true)
        {
            GameObject.Find("GreatSword").GetComponent<GreatSword>().Block = false;
            GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("IronStrongGreatSwordBlock", false);
        }
        if (SteelWeakGreatSwordActive == true)
        {
            GameObject.Find("GreatSword").GetComponent<GreatSword>().Block = false;
            GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("SteelWeakGreatSwordBlock", false);
        }
        if (SteelMediumGreatSwordActive == true)
        {
            GameObject.Find("GreatSword").GetComponent<GreatSword>().Block = false;
            GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("SteelMediumGreatSwordBlock", false);
        }
        if (SteelStrongGreatSwordActive == true)
        {
            GameObject.Find("GreatSword").GetComponent<GreatSword>().Block = false;
            GameObject.Find("GreatSword").GetComponent<GreatSword>().m_Anim.SetBool("SteelStrongGreatSwordBlock", false);
        }
        //broad swords
        if (WoodWeakBroadSwordActive == true)
        {
            GameObject.Find("BroadSword").GetComponent<BroadSword>().Block = false;
            GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("WoodWeakBroadSwordBlock", false);
        }
        if (WoodMediumBroadSwordActive == true)
        {
            GameObject.Find("BroadSword").GetComponent<BroadSword>().Block = false;
            GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("WoodMediumBroadSwordBlock", false);
        }
        if (WoodStrongBroadSwordActive == true)
        {
            GameObject.Find("BroadSword").GetComponent<BroadSword>().Block = false;
            GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("WoodStrongBroadSwordBlock", false);
        }
        if (IronWeakBroadSwordActive == true)
        {
            GameObject.Find("BroadSword").GetComponent<BroadSword>().Block = false;
            GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("IronWeakBroadSwordBlock", false);
        }
        if (IronMediumBroadSwordActive == true)
        {
            GameObject.Find("BroadSword").GetComponent<BroadSword>().Block = false;
            GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("IronMediumBroadSwordBlock", false);
        }
        if (IronStrongBroadSwordActive == true)
        {
            GameObject.Find("BroadSword").GetComponent<BroadSword>().Block = false;
            GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("IronStrongBroadSwordBlock", false);
        }
        if (SteelWeakBroadSwordActive == true)
        {
            GameObject.Find("BroadSword").GetComponent<BroadSword>().Block = false;
            GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("SteelWeakBroadSwordBlock", false);
        }
        if (SteelMediumBroadSwordActive == true)
        {
            GameObject.Find("BroadSword").GetComponent<BroadSword>().Block = false;
            GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("SteelMediumBroadSwordBlock", false);
        }
        if (SteelStrongBroadSwordActive == true)
        {
            GameObject.Find("BroadSword").GetComponent<BroadSword>().Block = false;
            GameObject.Find("BroadSword").GetComponent<BroadSword>().m_Anim.SetBool("SteelStrongBroadSwordBlock", false);
        }
        //common axes
        if (WoodWeakCommonAxeActive == true)
        {
            GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Block = false;
            GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("WoodWeakCommonAxeBlock", false);
        }
        if (WoodMediumCommonAxeActive == true)
        {
            GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Block = false;
            GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("WoodMediumCommonAxeBlock", false);
        }
        if (WoodStrongCommonAxeActive == true)
        {
            GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Block = false;
            GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("WoodStrongCommonAxeBlock", false);
        }
        if (IronWeakCommonAxeActive == true)
        {
            GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Block = false;
            GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("IronWeakCommonAxeBlock", false);
        }
        if (IronMediumCommonAxeActive == true)
        {
            GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Block = false;
            GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("IronMediumCommonAxeBlock", false);
        }
        if (IronStrongCommonAxeActive == true)
        {
            GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Block = false;
            GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("IronStrongCommonAxeBlock", false);
        }
        if (SteelWeakCommonAxeActive == true)
        {
            GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Block = false;
            GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("SteelWeakCommonAxeBlock", false);
        }
        if (SteelMediumCommonAxeActive == true)
        {
            GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Block = false;
            GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("SteelMediumCommonAxeBlock", false);
        }
        if (SteelStrongCommonAxeActive == true)
        {
            GameObject.Find("CommonAxe").GetComponent<CommonAxe>().Block = false;
            GameObject.Find("CommonAxe").GetComponent<CommonAxe>().m_Anim.SetBool("SteelStrongCommonAxeBlock", false);
        }
        //battle axes
        if (WoodWeakBattleAxeActive == true)
        {
            GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Block = false;
            GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("WoodWeakBattleAxeBlock", false);
        }
        if (WoodMediumBattleAxeActive == true)
        {
            GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Block = false;
            GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("WoodMediumBattleAxeBlock", false);
        }
        if (WoodStrongBattleAxeActive == true)
        {
            GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Block = false;
            GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("WoodStrongBattleAxeBlock", false);
        }
        if (IronWeakBattleAxeActive == true)
        {
            GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Block = false;
            GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("IronWeakBattleAxeBlock", false);
        }
        if (IronMediumBattleAxeActive == true)
        {
            GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Block = false;
            GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("IronMediumBattleAxeBlock", false);
        }
        if (IronStrongBattleAxeActive == true)
        {
            GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Block = false;
            GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("IronStrongBattleAxeBlock", false);
        }
        if (SteelWeakBattleAxeActive == true)
        {
            GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Block = false;
            GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("SteelWeakBattleAxeBlock", false);
        }
        if (SteelMediumBattleAxeActive == true)
        {
            GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Block = false;
            GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("SteelMediumBattleAxeBlock", false);
        }
        if (SteelStrongBattleAxeActive == true)
        {
            GameObject.Find("BattleAxe").GetComponent<BattleAxe>().Block = false;
            GameObject.Find("BattleAxe").GetComponent<BattleAxe>().m_Anim.SetBool("SteelStrongBattleAxeBlock", false);
        }
        //war axes
        if (WoodWeakWarAxeActive == true)
        {
            GameObject.Find("WarAxe").GetComponent<WarAxe>().Block = false;
            GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("WoodWeakWarAxeBlock", false);
        }
        if (WoodMediumWarAxeActive == true)
        {
            GameObject.Find("WarAxe").GetComponent<WarAxe>().Block = false;
            GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("WoodMediumWarAxeBlock", false);
        }
        if (WoodStrongWarAxeActive == true)
        {
            GameObject.Find("WarAxe").GetComponent<WarAxe>().Block = false;
            GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("WoodStrongWarAxeBlock", false);
        }
        if (IronWeakWarAxeActive == true)
        {
            GameObject.Find("WarAxe").GetComponent<WarAxe>().Block = false;
            GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("IronWeakWarAxeBlock", false);
        }
        if (IronMediumWarAxeActive == true)
        {
            GameObject.Find("WarAxe").GetComponent<WarAxe>().Block = false;
            GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("IronMediumWarAxeBlock", false);
        }
        if (IronStrongWarAxeActive == true)
        {
            GameObject.Find("WarAxe").GetComponent<WarAxe>().Block = false;
            GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("IronStrongWarAxeBlock", false);
        }
        if (SteelWeakWarAxeActive == true)
        {
            GameObject.Find("WarAxe").GetComponent<WarAxe>().Block = false;
            GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("SteelWeakWarAxeBlock", false);
        }
        if (SteelMediumWarAxeActive == true)
        {
            GameObject.Find("WarAxe").GetComponent<WarAxe>().Block = false;
            GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("SteelMediumWarAxeBlock", false);
        }
        if (SteelStrongWarAxeActive == true)
        {
            GameObject.Find("WarAxe").GetComponent<WarAxe>().Block = false;
            GameObject.Find("WarAxe").GetComponent<WarAxe>().m_Anim.SetBool("SteelStrongWarAxeBlock", false);
        }
    }
}

