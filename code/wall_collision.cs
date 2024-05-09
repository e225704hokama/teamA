using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class wall_collision : MonoBehaviour
{
    [SerializeField]    private TextMeshProUGUI miss_count_text;
    private int score=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Destroy(gameObject);
        Debug.Log("player collision ON");
        score+=1;
        miss_count_text.text="miss:"+score.ToString();
        
    }

}
