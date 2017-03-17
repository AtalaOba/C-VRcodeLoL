using UnityEngine;
using System.Collections;

public class GolemSpell : MonoBehaviour {

 private Transform targetblack;
    
    public float speed = 5f;
	public float turnSpeed = 15f;
    private int blackIndex = 0;
    
    
    
    /*
	public int EnemieLife = 100;
	public bool AttackMode1 = false;
	public bool AttackMode2 = false;
	public bool AttackMode3 = false;
	public bool idle = false;
	public bool dead = false;
*/
    
	// Use this for initialization
	void Start () {
	targetblack = BlackWayPoints.blackWayPoints[0];
	}
	
	// Update is called once per frame
	void Update () {
	Vector3 dirblack = targetblack.position - transform.position;
		transform.Translate (dirblack.normalized * speed * Time.deltaTime, Space.World);
        Quaternion lookRotation = Quaternion.LookRotation(dirblack);
		Vector3 rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
		transform.rotation = Quaternion.Euler (0f, rotation.y, 0f);
		//transform.Rotate (dirshort);

			//transform.rotation = dirshort;
		if (Vector3.Distance (transform.position, targetblack.position) <= 0.2f) {
			GetNextBlackpoint ();
		}
    
	}
    
    void GetNextBlackpoint()
	{
		if (blackIndex >= (BlackWayPoints.blackWayPoints.Length)-1) {
			Destroy (gameObject);
			return;
		}

		blackIndex++;
		targetblack = BlackWayPoints.blackWayPoints[blackIndex];
	}
}
