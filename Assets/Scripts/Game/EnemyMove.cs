using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour {

    [SerializeField]
    private Transform target;
    NavMeshAgent agent;

    // Use this for initialization
    void Start () {
        target = GameObject.Find("OVRCameraRigWithGun").GetComponent<Transform>();
        agent = GetComponent<NavMeshAgent>();
    }
	
    /// <summary>
    /// Playerの座標に等速で移動
    /// </summary>
	// Update is called once per frame
	void Update () {
        agent.SetDestination(target.transform.position);
        agent.speed = 1;
    }
}
