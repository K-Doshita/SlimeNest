using UnityEngine;

public class BulletDestroy : MonoBehaviour {

	/// <summary>
    /// 弾がステージか敵に当たったら弾を削除
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Stage" || collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
