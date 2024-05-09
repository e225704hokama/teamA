using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class wall_collision : MonoBehaviour
{
    [SerializeField]    private TextMeshProUGUI miss_count_text;
    private player_collision playerCollision;
    private int miss_count=0;
    // Start is called before the first frame update
    void Start()
    {
        playerCollision = GameObject.FindObjectOfType<player_collision>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Destroy(gameObject);
        Debug.Log("player collision ON");
        miss_count+=1;
        miss_count_text.text="miss:"+miss_count.ToString();
        int scoreValue = playerCollision.score;
        PlayerPrefs.SetInt("Score", scoreValue);
        PlayerPrefs.Save(); // 重要：変更を保存する
        SceneManager.LoadScene("result_frame");
        
    }

}
