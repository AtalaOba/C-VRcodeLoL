using UnityEngine;
using System.Collections;

public class Wizardtowred : MonoBehaviour {
    
    private Transform targetblueranked;    

	[Header("Attributes")]

	public float range = 15f;
	public float fireRate = 1f;
	private float fireCountdown = 0f;

	[Header("Unity Setup Fields")]

    public string BlueRankedWave = "BlueRankedWave";
	
	public float turnSpeed = 10f;

	public GameObject shotower;
	public Transform firePoint;

	// Use this for initialization
	void Start () {
        InvokeRepeating("UpdateTargetRanked", 0f, 0.5f);
	}
    
    void Update () {
		
        if (targetblueranked == null)
			return;        
		//Target lock on        
        Vector3 dirrankedblue = targetblueranked.position - transform.position;
        
		Quaternion lookRotation2b = Quaternion.LookRotation(dirrankedblue);
		Vector3 rotation2b = Quaternion.Lerp(transform.rotation, lookRotation2b, Time.deltaTime * turnSpeed).eulerAngles;
		transform.rotation = Quaternion.Euler (0f, rotation2b.y, 0f);

		if (fireCountdown <= 0f)
		{
			Shoot();
			fireCountdown = 1f / fireRate;
		}

		fireCountdown -= Time.deltaTime;

	}
	
	
    
    void UpdateTargetRanked () {   GameObject[] bluewizards = GameObject.FindGameObjectsWithTag(BlueRankedWave);
		float shortestDistancewizard = Mathf.Infinity;
		GameObject nearestWizard = null;
		foreach (GameObject bluewizard in bluewizards)
		{
            float distanceToWizard = Vector3.Distance(transform.position, bluewizard.transform.position);
			if (distanceToWizard < shortestDistancewizard)
			{
				shortestDistancewizard = distanceToWizard;
				nearestWizard = bluewizard;
			}
		}

		if (nearestWizard != null && shortestDistancewizard <= range)
		{
			targetblueranked = nearestWizard.transform;
		} else
		{
			targetblueranked = null;
		}
    }
    
	void Shoot () {
		GameObject bulletGO = (GameObject)Instantiate(shotower, firePoint.position, firePoint.rotation);
		Bullet bullet = bulletGO.GetComponent<Bullet>();

		if (bullet != null)
			
            bullet.Seek(targetblueranked);
        
	}

	void OnDrawGizmosSelected () {
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, range);
	}
}
