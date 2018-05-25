using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour {

    public static CanvasManager instance;

    public Text textScore;
    public Text textMoney;
    public Text textLife;

    public int priceBomb;

    void Awake()
    {
        instance = this;
    }

    void Start () {


    }

    public void UpdateHUD()
    {
        textScore.text = "Score: " + GameManager.instance.score;
        textMoney.text = "Money: " + GameManager.instance.money;
        textLife.text = "Life: " + GameManager.instance.life;
    }
    

    public void onButtonBombClick()
    {
        if(GameManager.instance.money > priceBomb){
            
        }
    }

}
