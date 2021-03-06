using UnityEngine;

public class ResultDoor : MonoBehaviour
{

    private ResultFadeOutController fade;
    public GameObject move;
    // Use this for initialization
    void Start()
    {
        fade = GameObject.Find("FadeOut").GetComponent<ResultFadeOutController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// 移動できないようにし、フェード開始
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            move.SetActive(false);
            fade.isFadeOUt = true;
        }
    }
}
