using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleFadeOutController : MonoBehaviour
{


    float fadespeed = 0.01f;
    float red, green, blue, alpha;

    public bool isFadeOUt = false;

    Image fadeImage;

    // Use this for initialization
    void Start()
    {
        fadeImage = GetComponent<Image>();
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alpha = fadeImage.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFadeOUt)
        {
            StartFadeOut();
            StartCoroutine(Scene());
        }
    }

    /// <summary>
    /// ImageのAlpha値を徐々に上げてフェードを実施
    /// </summary>
    void StartFadeOut()
    {
        fadeImage.enabled = true;
        alpha += fadespeed;
        SetAlpha();
        if (alpha >= 1)
        {
            isFadeOUt = false; //完全に不透明になったので処理抜け
        }
    }

    /// <summary>
    /// alpha値をImageに反映
    /// </summary>
    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alpha);
    }

    /// <summary>
    /// フェード後シーン遷移
    /// </summary>
    /// <returns></returns>
    IEnumerator Scene()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("GameScene");
    }
}