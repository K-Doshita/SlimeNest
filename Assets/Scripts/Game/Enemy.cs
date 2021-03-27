using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject explosion;
    public ScoreManager scoreManager;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    /// <summary>
    /// 弾が当たると10点加点されてオブジェクト削除
    /// </summary>
    /// <param name="collision"></param>
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            scoreManager.AddScore(10);
            audioSource.Play();
            Destroy(this.gameObject);
            Destroy(collision.gameObject);


        }
    }

}