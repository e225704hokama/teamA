using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    

    public Text scoretext; // スコアを表示するUIテキストオブジェクト
    //public GameObject score_object = "aaa"; // Textオブジェクト

    private int score; // スコア


    void Start()
    {
        //Text score_point = score_object.GetComponent<Text> ();
        scoretext.text="0";
        //UpdateScoreText(); // 初期スコアを表示
    }



    void UpdateScoreText()
    {
        scoretext.text="9999";
        //score_point.text = "Score: " + score.ToString();
    }
}
