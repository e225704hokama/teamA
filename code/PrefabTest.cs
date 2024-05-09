using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PrefabTest : MonoBehaviour {


    // Use this for initialization
    /*
    void Start  () {
        // CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load ("coin");
        // Cubeプレハブを元に、インスタンスを生成、
        Instantiate (obj, new Vector3(0.0f,2.0f,0.0f), Quaternion.identity);
    }
    */
    private void Start()
    {
        InvokeRepeating("DoSomething", 0f, 0.3f); // n秒ごとにDoSomethingメソッドを実行する
    }

    private void DoSomething()
    {
        Debug.Log("DoSomething");

        int randomValue = UnityEngine.Random.Range(0, 3); // 0から2までのランダムな整数値を取得する


        GameObject obj = (GameObject)Resources.Load ("coin");

        //Instantiate (obj, new Vector3(0.0f,2.0f,0.0f), Quaternion.identity);

        switch (randomValue)
            {
                case 0:
                    // valueが0の場合の処理
                    //Instantiate (obj, new Vector3(11.0f,-11.5f,0.0f), Quaternion.identity);
                    Instantiate (obj, new Vector3(11.0f,-11.5f,0.0f), Quaternion.identity);
                    Debug.Log("///////////////////////////////////////");
                    break;
                case 1:
                    // valueが1の場合の処理
                    //Instantiate (obj, new Vector3(11.0f,-8.5f,0.0f), Quaternion.identity);
                    Debug.Log("////////////////////////////////////////////////////////////////");
                    Instantiate (obj, new Vector3(11.0f,-8.5f,0.0f), Quaternion.identity);
                    break;
                case 2:
                    // valueが2の場合の処理
                    Instantiate (obj, new Vector3(11.0f,-5.5f,0.0f), Quaternion.identity);
                    Debug.Log("//////////////////////////////////////////////");
                    break;
                default:
                    // 上記のいずれの条件にも当てはまらない場合の処理
                    Instantiate (obj, new Vector3(0.0f,-1f,0.0f), Quaternion.identity);
                    Debug.Log("invalid line has called");
                    break;
            }
    }

}