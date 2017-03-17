using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RedSpawner : MonoBehaviour {

	public Transform spawnPoint;

	public Transform redbasic;
	public Transform redwizard;
	public Transform redcanon;

	private float countdown = 2f;
	public Text waveCountdownText;
	private int waveNum = 0;
    public Transform redchamp;
    
    
    public Transform turretredmele;
    public Transform turretredwizard;
    public Transform turretredcanon;
    
    public static Transform[] turretspositions;
	
    public float timeBetweenWaves = 5f;
    
    void Awake()
    {
		SpawnTurrets();
    }
	void Update ()
	{
		Timer();
	}

	IEnumerator SpawnWave ()
	{
		waveNum = 1;

		for (int i = 0; i < waveNum; i++)
		{
			SpawnBR();
            yield return new WaitForSeconds(2.5f);
            SpawnWR();
            yield return new WaitForSeconds(2.5f);
            SpawnCR();
		}
	}

	void SpawnBR(){
		Instantiate(redbasic, spawnPoint.position, spawnPoint.rotation);
	}
    void SpawnWR(){
        Instantiate(redwizard, spawnPoint.position, spawnPoint.rotation);
    }
    void SpawnCR(){
    Instantiate(redcanon, spawnPoint.position, spawnPoint.rotation);
    }
    
    
     void SpawnTurrets()
    {
     turretspositions = new Transform[transform.childCount];
		for (int i = 0; i < turretspositions.Length; i++) {
			turretspositions[i] = transform.GetChild(i);
            if(i>=0 && i<=1)
            Instantiate(turretredcanon, turretspositions[i].position, turretredcanon.rotation);
            if(i>=2 && i<=3)
            Instantiate(turretredwizard, turretspositions[i].position, turretredwizard.rotation);
            if(i>=4)
            Instantiate(turretredmele, turretspositions[i].position, turretredmele.rotation);  
            }
    }
        
    void Timer()
    {
        if (countdown <= 0f)
		  {
			 StartCoroutine(SpawnWave());
			 countdown = timeBetweenWaves;
		  }

		  countdown -= Time.deltaTime;

		  countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

		  waveCountdownText.text = string.Format("{0:00.00}", countdown);
    }


}
