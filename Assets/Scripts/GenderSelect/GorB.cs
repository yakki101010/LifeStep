using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GorB : MonoBehaviour
{
    // シングルトンインスタンス
    // このプロパティを通じて、どこからでもゲームマネージャーのインスタンスにアクセスできます
    public static GorB Instance { get; private set; }

    // シーン間で共有するデータ
    // これらの変数は、シーン間で保持される値を格納します

    public bool gorb;//男か女か 

    // 他のデータを追加できます

    private void Awake()
    {
        // シングルトンパターンの実装
        if (Instance == null)
        {
            // 既存のゲームマネージャーインスタンスがない場合、
            // 現在のインスタンスを設定し、シーン遷移時に破棄されないようにします
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // 既存のゲームマネージャーインスタンスがある場合、
            // 重複を避けるために現在のインスタンスを破棄します
            Destroy(gameObject);
        }
    }
    public void BoyBottn()
    {
        gorb = true;
    }
    public void GirlBottn()
    {
        gorb = false;
    }
    public void OkBottn()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
