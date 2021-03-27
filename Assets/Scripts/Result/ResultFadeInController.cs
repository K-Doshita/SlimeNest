using UnityEngine;
using UnityEngine.UI;

public class ResultFadeInController : MonoBehaviour
{

    float fadespeed = 0.01f;
    float red, green, blue, alpha;

    public bool isFadeIn = true;

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
        if (isFadeIn)
        {
            StartFadeIn();
        }
    }

    /// <summary>
    /// ImageのAlpha値を徐々に下げてフェードを実施
    /// </summary>
    void StartFadeIn()
    {

        alpha -= fadespeed;
        SetAlpha();

        if (alpha <= 0)
        {
            isFadeIn = false;
            fadeImage.enabled = false;
        }
    }

    /// <summary>
    /// alpha値をImageに反映
    /// </summary>
    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alpha);
    }
}
