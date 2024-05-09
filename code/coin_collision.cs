using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Coin_collision : MonoBehaviour
{
    [SerializeField] TMP_change_test TMP_change_test;


    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        //ScoreManager_test.Instance.UpdateScoreText();
        //GameManager.Instance.UpdateScore();
        Debug.Log("OnTriggerEnter2D: " + other.gameObject.name);
        //TMP_change_test.add_score_script(1);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("OnTriggerStay2D: " + other.gameObject.name);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("OnTriggerExit2D: " + other.gameObject.name);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter2D: " + collision.gameObject.name);
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("OnCollisionStay2D: " + collision.gameObject.name);
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("OnCollisionExit2D: " + collision.gameObject.name);
    }
}