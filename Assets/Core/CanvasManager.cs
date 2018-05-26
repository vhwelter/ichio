using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour {

    public static CanvasManager instance;

    public Text textScore;
    public Text textMoney;
    public Text textLife;

    [Header("Traps Prices")]
    public int priceBomb;

    public GameObject prefabBomb;

    public bool trap;

    void Awake()
    {
        instance = this;
    }

    void Start () {
        trap = false;
    }

    void Update ()
    {  
        

        if (Input.GetMouseButtonDown(0) && trap){
            if (GameManager.instance.money >= priceBomb){
                GameManager.instance.money -= priceBomb;
                UpdateHUD();
                Instantiate(prefabBomb, Input.mousePosition, Quaternion.identity);
                trap = false;
            }
        }
    }

    public void UpdateHUD()
    {
        textScore.text = "Score: " + GameManager.instance.score;
        textMoney.text = "Money: " + GameManager.instance.money;
        textLife.text = "Life: " + GameManager.instance.life;
    }
    

    public void onButtonBombClick()
    {
        trap = true;
    }

}
