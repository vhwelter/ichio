using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour {

    public static CanvasManager instance;

    public Text textScore;
    public Text textMoney;
    public Text textLife;

    [Header("Traps Prices")]
    public int priceBearTrap;
    public int priceBomb;
    public int priceMouse;
    public int priceFire;

    [Header("Traps Prefabs")]
    public GameObject prefabBearTrap;
    public GameObject prefabBomb;
    public GameObject prefabMouse;
    public GameObject prefabFire;

    [Header("Traps Damage")]
    public int damageBearTrap;
    public int damageBomb;
    public int damageMouse;
    public int damageFire;

    public int trap;

    void Awake()
    {
        instance = this;
    }

    void Start () {
        trap = 0;
    }

    void Update ()
    {  
        if (Input.GetMouseButtonDown(0) && trap != 0){
            switch(trap)
            {
                case 1:
                    CreatTrap(prefabBearTrap, priceBearTrap, damageBearTrap);
                    break;
                case 2:
                    CreatTrap(prefabBomb, priceBomb, damageBomb);
                    break;
                case 3:
                    CreatTrap(prefabMouse, priceMouse, damageMouse);
                    break;
                case 4:
                    CreatTrap(prefabFire, priceFire, damageFire);
                    break;
            }
        }
    }

    public void UpdateHUD()
    {
        textScore.text = "Score: " + GameManager.instance.score;
        textMoney.text = "Money: " + GameManager.instance.money;
        textLife.text = "Life: " + GameManager.instance.life;
    }
    
    public void onButtonBearTrapClick()
    {
        trap = 1;
    }

    public void onButtonBombClick()
    {
        trap = 2;
    }

    public void onButtonMouseClick()
    {
        trap = 3;
    }

    public void onButtonFireClick()
    {
        trap = 4;
    }

    public void CreatTrap(GameObject prefabSelected, int priceSelected, int damageSelected)
    {
        if (GameManager.instance.money >= priceSelected){
            GameManager.instance.money -= priceSelected;
            UpdateHUD();
            Vector2 creatPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject gb = Instantiate(prefabSelected, creatPosition, Quaternion.identity);
            gb.GetComponent<TrapController>().setDamage(damageSelected);
            trap = 0;
        }
    }

}
