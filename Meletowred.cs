using UnityEngine;
using System.Collections;

public class Meletowred : MonoBehaviour {
private Transform targetbluemele;

	[Header("Attributes")]

	public float range = 15f;
	public float fireRate = 1f;
	private float fireCountdown = 0f;

	[Header("Unity Setup Fields")]
	
    public string BlueMeleWave = "BlueMeleWave";
	public float turnSpeed = 10f;

	public GameObject shotower;
	public Transform firePoint;

	// Use this for initialization
	void Start () {
        InvokeRepeating("UpdateTargetMele", 0f, 2f);
	}
    
    void Update () {
        if (targetbluemele == null)
			return;
        
       
		//Target lock on
        
        Vector3 dirmeleblue = targetbluemele.position - transform.position;
		Quaternion lookRotation2r = Quaternion.LookRotation(dirmeleblue);
		Vector3 rotation2r = Quaternion.Lerp(transform.rotation, lookRotation2r, Time.deltaTime * turnSpeed).eulerAngles;
		transform.rotation = Quaternion.Euler (0f, rotation2r.y, 0f);
        
        
		if (fireCountdown <= 0f)
		{
			Shoot();
			fireCountdown = 1f / fireRate;
		}

		fireCountdown -= Time.deltaTime;

	}
    
    void UpdateTargetMele(){
    GameObject[] bluemeles = GameObject.FindGameObjectsWithTag(BlueMeleWave);
		float shortestDistancemele = Mathf.Infinity;
		GameObject nearestMele = null;
		foreach (GameObject bluemele in bluemeles)
		{
            float distanceToMele = Vector3.Distance(transform.position, bluemele.transform.position);
			if (distanceToMele < shortestDistancemele)
			{
				shortestDistancemele = distanceToMele;
				nearestMele = bluemele;
			}
		}

		if (nearestMele != null && shortestDistancemele <= range)
		{
			targetbluemele = nearestMele.transform;
		} else
		{
			targetbluemele = null;
		}
        
        
        

    }
    

	void Shoot () {
		GameObject bulletGO = (GameObject)Instantiate(shotower, firePoint.position, firePoint.rotation);
		Bullet bullet = bulletGO.GetComponent<Bullet>();

		if (bullet != null)
			bullet.Seek(targetbluemele);
            
	}

	void OnDrawGizmosSelected (){
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere(transform.position, range);
	}
}
