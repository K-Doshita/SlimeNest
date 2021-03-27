using System.Collections;
using UnityEngine;

public class TimeManager : MonoBehaviour
{

    public float time = 90;

    private GameFadeOutController fadeOut;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        fadeOut = GameObject.Find("FadeOut").GetComponent<GameFadeOutController>();
        audioSource = GetComponent<AudioSource>();
        StartCoroutine("Bell");
    }

    /// <summary>
    /// 90秒経過するまでに体力が0にならなければResultSceneに遷移
    /// </summary>
    // Update is called once per frame
    private void FixedUpdate()
    {
        time -= Time.deltaTime;

        if (time <= 0)
        {
            fadeOut.isFadeOUt = true;
        }
    }

    /// <summary>
    /// 残り時間60秒、30秒、20秒、10秒のタイミングでベルを鳴らす
    /// </summary>
    /// <returns></returns>
    IEnumerator Bell()
    {
        yield return new WaitForSeconds(30);
        audioSource.Play();
        yield return new WaitForSeconds(30);
        audioSource.Play();
        yield return new WaitForSeconds(10);
        audioSource.Play();
        yield return new WaitForSeconds(10);
        audioSource.Play();
    }
}
