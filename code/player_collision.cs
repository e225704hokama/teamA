using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class player_collision : MonoBehaviour
{
    [SerializeField]    private TextMeshProUGUI increment_score_text;

    public int score=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Coin")){        
            score+=1*100;
            increment_score_text.text="score:"+score.ToString();
            Debug.Log("coinに衝突を検知しました");
            //PlayerPrefs.SetInt("Score", score);
            //PlayerPrefs.Save(); // 重要：変更を保存する
            //SceneManager.LoadScene("result_frame");
        }
        //Destroy(gameObject);
        Debug.Log("player collision ON");

        
    }

}
