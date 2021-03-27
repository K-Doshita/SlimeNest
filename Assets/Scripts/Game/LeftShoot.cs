using UnityEngine;

public class LeftShoot : MonoBehaviour
{

    public GameObject bullet;
    public Transform muzzle;
    public float speed = 500;

    private OVRHapticsClip hapticsClip;

    private AudioSource audioSource;


    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        byte[] samples = new byte[8];
        for (int i = 0; i < samples.Length; i++)
        {
            samples[i] = 255;
        }
        hapticsClip = new OVRHapticsClip(samples, samples.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger))
        {

            Shot();
            OVRHaptics.LeftChannel.Mix(hapticsClip);
            audioSource.Play();
        }
    }


    /// <summary>
    /// 弾を生成し発射
    /// </summary>
    public void Shot()
    {
        GameObject bullets = bullet;

        bullets.transform.position = muzzle.position;

        bullets = Instantiate(bullet, muzzle.position, muzzle.rotation);
        bullets.tag = "bullet";

        bullets.GetComponent<Rigidbody>().AddForce(muzzle.transform.forward * speed);

        Destroy(bullets, 5f);
    }
}
