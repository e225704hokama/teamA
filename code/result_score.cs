using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class result_score : MonoBehaviour
{
    [SerializeField]    private TextMeshProUGUI score_num;
    // Start is called before the first frame update
    void Start()
    {
        int score = PlayerPrefs.GetInt("Score");
        Debug.Log(score.ToString()+":ですよ");
        score_num.text=score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
