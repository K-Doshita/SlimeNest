using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDamage : MonoBehaviour
{

    [SerializeField]
    private int playerHp = 200;
    private float red, green, blue, alpha;
    private DeadFadeOutController fade;
    private float fadeSpeed = 0.01f;
    private AudioSource audioSource;

    public Image damageImage;


    // Use this for initialization
    void Start()
    {
        fade = GameObject.Find("DeadFadeOut").GetComponent<DeadFadeOutController>();
        red = damageImage.color.r;
        green = damageImage.color.g;
        blue = damageImage.color.b;
        alpha = damageImage.color.a;

        audioSource = GetComponent<AudioSource>();

    }

    /// <summary>
    /// 敵に当たると体力が減り視界が赤くなっていく、体力が0以下になるとDeadSceneへ遷移
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            audioSource.Play();

            if (playerHp <= 0)
            {
                damageImage.color = new Color(red, green, blue, alpha);
                alpha += fadeSpeed;
                StartCoroutine("PlayerDead");
            }
            else
            {
                playerHp -= 10;

                damageImage.color = new Color(red, green, blue, alpha);
                alpha += 0.0235294118f;
            }
        }
    }


    /// <summary>
    /// フェード開始
    /// </summary>
    /// <returns></returns>
    IEnumerator PlayerDead()
    {
        yield return new WaitForSeconds(3f);
        fade.isFadeOUt = true;
        alpha = 0;
    }


}

