using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TMP_change_test : MonoBehaviour {
    [SerializeField]    
    private TextMeshProUGUI cardNameText;
    
    //int score = 0;

    void Start() {
        cardNameText.text = "call_start(score:0)";
    }

    public void add_score_script(int point){
        //score +=point;
        //cardNameText.text=point.ToString();
    }
}
