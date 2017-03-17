using UnityEngine;

public class WizardEnemieBlue : MonoBehaviour {

	private Transform targetshort;
	private Transform targetlong;
	private	Transform targetblack;
    
	public float speed = 2f;
	public float turnSpeed = 0.5f;
    
    private int shortIndex = 0;
	private int longIndex = 0;
	private int blackIndex = 0;
	/*
	public int EnemieLife = 100;
	public bool AttackMode1 = false;
	public bool AttackMode2 = false;
	public bool AttackMode3 = false;
	public bool idle = false;
	public bool dead = false;
*/
	void Start () {
		targetshort = ShortWayPoints.shortWayPoints[0];
		targetlong = LongWayPoints.longWayPoints[0];
		targetblack = BlackWayPoints.blackWayPoints[0];
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 dirshort = targetshort.position - transform.position;
		transform.Translate (dirshort.normalized * speed * Time.deltaTime, Space.World);
        Quaternion lookRotation = Quaternion.LookRotation(dirshort);
		Vector3 rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
		transform.rotation = Quaternion.Euler (0f, rotation.y, 0f);
		//transform.Rotate (dirshort);

			//transform.rotation = dirshort;
		if (Vector3.Distance (transform.position, targetshort.position) <= 0.2f) {
			GetNextShortpoint ();
		}

	}


	void GetNextShortpoint()
	{
		if (shortIndex >= (ShortWayPoints.shortWayPoints.Length)-1) {
			Destroy (gameObject);
			return;
		}

		shortIndex++;
		targetshort = ShortWayPoints.shortWayPoints[shortIndex];
	}
	void GetNextLongpoint()
	{
		if (longIndex >= (LongWayPoints.longWayPoints.Length)-1) {
			Destroy (gameObject);
			return;
		}

		longIndex++;
		targetlong = LongWayPoints.longWayPoints[longIndex];
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

