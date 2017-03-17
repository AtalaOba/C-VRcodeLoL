using UnityEngine;
using System.Collections;

public class Canontowred : MonoBehaviour {
private Transform targetbluecanon;

	[Header("Attributes")]

	public float range = 15f;
	public float fireRate = 1f;
	private float fireCountdown = 0f;

	[Header("Unity Setup Fields")]
	
    public string BlueCanonWave = "BlueCanonWave";
	public float turnSpeed = 10f;

	public GameObject shotower;
	public Transform firePoint;

	// Use this for initialization
	void Start () {
        InvokeRepeating("UpdateTargetCanon", 0f, 2f);
	}
    
    void Update () {
        if (targetbluecanon == null)
			return;
        
       
		//Target lock on
        
        Vector3 dircanonblue = targetbluecanon.position - transform.position;
		Quaternion lookRotation2r = Quaternion.LookRotation(dircanonblue);
		Vector3 rotation2r = Quaternion.Lerp(transform.rotation, lookRotation2r, Time.deltaTime * turnSpeed).eulerAngles;
		transform.rotation = Quaternion.Euler (0f, rotation2r.y, 0f);
        
        
		if (fireCountdown <= 0f)
		{
			Shoot();
			fireCountdown = 1f / fireRate;
		}

		fireCountdown -= Time.deltaTime;

	}
    
    void UpdateTargetCanon(){
    GameObject[] bluecanons = GameObject.FindGameObjectsWithTag(BlueCanonWave);
		float shortestDistanceCanon = Mathf.Infinity;
		GameObject nearestCanon = null;
		foreach (GameObject bluecanon in bluecanons)
		{
            float distanceToCanon = Vector3.Distance(transform.position, bluecanon.transform.position);
			if (distanceToCanon < shortestDistanceCanon)
			{
				shortestDistanceCanon = distanceToCanon;
				nearestCanon = bluecanon;
			}
		}

		if (nearestCanon != null && shortestDistanceCanon <= range)
		{
			targetbluecanon = nearestCanon.transform;
		} else
		{
			targetbluecanon = null;
		}
        
        
        

    }
    

	void Shoot () {
		GameObject bulletGO = (GameObject)Instantiate(shotower, firePoint.position, firePoint.rotation);
		Bullet bullet = bulletGO.GetComponent<Bullet>();

		if (bullet != null)
            bullet.Seek(targetbluecanon);
            
	}

	void OnDrawGizmosSelected (){
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere(transform.position, range);
	}
}
