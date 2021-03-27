using UnityEngine;

public class Enemy3 : MonoBehaviour
{

    public GameObject explosion;
    public ScoreManager scoreManager;
    public Color red;
    public Color blue;
    new Renderer renderer;

    int enemyLife = 3;

    AudioSource audioSource;
    // Use this for initialization
    void Start()
    {
        renderer = GetComponent<Renderer>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        audioSource = GetComponent<AudioSource>();
    }

    /// <summary>
    /// 弾が当たったときenemyLifeが1減り1か2なら色が変わり、0なら30点加点されてオブジェクト削除
    /// </summary>
    /// <param name="collision"></param>
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            enemyLife -= 1;

            if (enemyLife == 2)
            {
                renderer.material.color = red;
            }
            else if (enemyLife == 1)
            {
                renderer.material.color = blue;
            }
            else if (enemyLife == 0)
            {
                scoreManager.AddScore(30);
                audioSource.Play();
                Destroy(this.gameObject);
                Destroy(collision.gameObject);

            }

        }
    }
}
