using UnityEngine;

public class PlayerMove : MonoBehaviour {

    Vector2 stickL;

    public float speed;
   

    public GameObject centerEye;
    public GameObject player;
    
	// Use this for initialization
	void Start () {

    }
	
    /// <summary>
    /// ジョイスティックの操作によって移動
    /// </summary>
	// Update is called once per frame
	void Update () {

        stickL = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick);

        if (stickL.y > 0.5)
        {
            MoveForward();
        }
        if (stickL.y < -0.5)
        {
            MoveBack();
        }
        if (stickL.x > 0.5)
        {
            MoveRight();
        }
        if (stickL.x < -0.5)
        {
            MoveLeft();
        }

	}

    /// <summary>
    /// 前進
    /// </summary>
    private void MoveForward()
    {
        Vector3 HMDDir = centerEye.transform.rotation.eulerAngles;
        Quaternion moveRotation = Quaternion.Euler(0, HMDDir.y, 0);
        player.transform.position += (moveRotation * Vector3.forward).normalized * speed * Time.deltaTime;
    }

    /// <summary>
    /// 後退
    /// </summary>
    private void MoveBack()
    {
        Vector3 HMDDir = centerEye.transform.rotation.eulerAngles;
        Quaternion moveRotation = Quaternion.Euler(0, HMDDir.y, 0);
        player.transform.position -= (moveRotation * Vector3.forward).normalized * speed * Time.deltaTime;
    }

    /// <summary>
    /// 右移動
    /// </summary>
    private void MoveRight()
    {
        Vector3 HMDDir = centerEye.transform.rotation.eulerAngles;
        Quaternion moveRotation = Quaternion.Euler(0, HMDDir.y, 0);
        player.transform.position += (moveRotation * Vector3.right).normalized * speed * Time.deltaTime;
    }

    /// <summary>
    /// 左移動
    /// </summary>
    private void MoveLeft()
    {
        Vector3 HMDDir = centerEye.transform.rotation.eulerAngles;
        Quaternion moveRotation = Quaternion.Euler(0, HMDDir.y, 0);
        player.transform.position -= (moveRotation * Vector3.right).normalized * speed * Time.deltaTime;
    }
}
