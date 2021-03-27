using UnityEngine;
using UnityEngine.UI;

public class ResultText : MonoBehaviour {

    private int result = 0;
    public Text scoreText;

    /// <summary>
    /// スコア表示
    /// </summary>
    private void Awake()
    {
        GetComponent<Text>();
        result = ScoreManager.GetTotalScore();
        scoreText.text = "CONGRATULATIONS!\nYOUR SCORE\n" + result;

    }
}
