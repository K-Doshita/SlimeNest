using UnityEngine;

public class EnemyManager : MonoBehaviour {


    public GameObject[] enemy;
    public Transform[] enemySpawn;

    /// <summary>
    /// Scene開始から3秒後その後2秒おきに敵生成、3つの敵出現座標を配列に格納
    /// </summary>
	// Use this for initialization
	void Start () {

        InvokeRepeating("InstantiateEnemy", 3f, 2f);

        Transform[] enemySpawn = new Transform[3];
        for (int i = 0; i <= enemySpawn.Length -1; ++i)
        {
            enemySpawn[i] = GetComponent<Transform>();
            Debug.Log(i);
        }
	}
	
    /// <summary>
    /// ランダムな種類とランダムな位置で敵を出現させる
    /// </summary>
  public void InstantiateEnemy()
    {
        int number = Random.Range(0, 100);
        int spawnNumber = 0;


        if(number < 60)
        {
            spawnNumber = 0;
        }
        else if(60 <= number && number < 90)
        {
            spawnNumber = 1;
        }
        else if (90 <= number)
        {
            spawnNumber = 2;
        }

        int i = Random.Range(0, enemySpawn.Length);

        Instantiate(enemy[spawnNumber], enemySpawn[i].transform.position, Quaternion.identity);
    }
}
