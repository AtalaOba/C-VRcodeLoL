using UnityEngine;
using System.Collections;

public class Wizardtowblue : MonoBehaviour {
private Transform targetredranked;

	[Header("Attributes")]

	public float range = 15f;
	public float fireRate = 1f;
	private float fireCountdown = 0f;

	[Header("Unity Setup Fields")]
	
    public string RedRankedWave = "RedRankedWave";
	public float turnSpeed = 10f;

	public GameObject shotower;
	public Transform firePoint;

	// Use this for initialization
	void Start () {
        InvokeRepeating("UpdateTargetRanked", 0f, 2f);
	}
    
    void Update () {
        if (targetredranked == null)
			return;
        
       
		//Target lock on
        
        Vector3 dirrankedred = targetredranked.position - transform.position;
		Quaternion lookRotation2r = Quaternion.LookRotation(dirrankedred);
		Vector3 rotation2r = Quaternion.Lerp(transform.rotation, lookRotation2r, Time.deltaTime * turnSpeed).eulerAngles;
		transform.rotation = Quaternion.Euler (0f, rotation2r.y, 0f);
        
        
		if (fireCountdown <= 0f)
		{
			Shoot();
			fireCountdown = 1f / fireRate;
		}

		fireCountdown -= Time.deltaTime;

	}
    
    void UpdateTargetRanked(){
    GameObject[] redwizards = GameObject.FindGameObjectsWithTag(RedRankedWave);
		float shortestDistancewizard = Mathf.Infinity;
		GameObject nearestWizard = null;
		foreach (GameObject redwizard in redwizards)
		{
            float distanceToWizard = Vector3.Distance(transform.position, redwizard.transform.position);
			if (distanceToWizard < shortestDistancewizard)
			{
				shortestDistancewizard = distanceToWizard;
				nearestWizard = redwizard;
			}
		}

		if (nearestWizard != null && shortestDistancewizard <= range)
		{
			targetredranked = nearestWizard.transform;
		} else
		{
			targetredranked = null;
		}
        
        
        

    }
    

	void Shoot () {
		GameObject bulletGO = (GameObject)Instantiate(shotower, firePoint.position, firePoint.rotation);
		Bullet bullet = bulletGO.GetComponent<Bullet>();

		if (bullet != null)
            bullet.Seek(targetredranked);
            
	}

	void OnDrawGizmosSelected (){
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere(transform.position, range);
	}
}

