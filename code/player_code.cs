using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class MoveUpDown : MonoBehaviour
{
    //[SerializeField]    private TextMeshProUGUI cardNameText;
    //private int test=0;
    private float speed = 3f; // 上下に一回で移動する座標
    private float maxY = 500f; // 移動の上限位置
    private float minY = -500f; // 移動の下限位置

    public float start_positon=1;

    void Start(){
        Application.targetFrameRate = 120;
        transform.position = new Vector3(-5,-8,0);
    }

    void Update()
    {
        //test +=1;
        //cardNameText.text = "score:"+test.ToString();

        // 上ボタンが押されたら上に移動
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {   
            if(start_positon<2){
                start_positon=start_positon+1;
                transform.Translate(Vector2.up * speed );
            }
        }


        // 下ボタンが押されたら下に移動
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(start_positon>0){

                start_positon=start_positon-1;
                transform.Translate(Vector2.down * speed);
            }
        }

        // 移動範囲を制限 (用意してるけど今は使ってない)
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, minY, maxY), transform.position.z);
    }
}
