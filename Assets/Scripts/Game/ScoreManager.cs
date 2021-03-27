using UnityEngine;

public class ScoreManager : MonoBehaviour
{


    public static int score;

    /// <summary>
    /// 合計スコア加算
    /// </summary>
    /// <param name="amount"></param>
    public void AddScore(int amount)
    {
        score += amount;

    }

    /// <summary>
    /// ResultSceneにスコアを返す
    /// </summary>
    /// <returns></returns>
    public static int GetTotalScore()
    {
        return score;
    }
}
