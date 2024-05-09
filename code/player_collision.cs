using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class player_collision : MonoBehaviour
{
    [SerializeField]    private TextMeshProUGUI increment_score_text;
    private int score=0;
    public string[] targetTags; // 接触を検出したいオブジェクトのタグの配列
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    void OnTriggerEnter2D(Collider2D other)
    {
        
        //Destroy(gameObject);
        Debug.Log("player collision ON");
        score+=1*100;
        increment_score_text.text="score:"+score.ToString();
        
    }
    */
    
    void OnTriggerEnter2D(Collider2D other)
    {
        // 接触した相手のタグが指定したタグの中に含まれているかどうかを確認する
        foreach (string tag in targetTags)
        {
            if (other.CompareTag("Coin"))
            {
                //Destroy(gameObject);
                Debug.Log("player collision ON");
                score+=1*100;
                increment_score_text.text="score:"+score.ToString();

                // スコアを増加させる処理などもここに追加します
                //break;  接触したオブジェクトが見つかればループを抜ける
            }
            if (other.CompareTag("bomb"))
            {
                //Destroy(gameObject);
                Debug.Log("player collision ON");
                score-=1*100;
                increment_score_text.text="score:"+score.ToString();

                // スコアを増加させる処理などもここに追加します
                //break;  接触したオブジェクトが見つかればループを抜ける
            }
        }

        

    }
}
