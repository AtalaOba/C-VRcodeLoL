using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BlueSpawner : MonoBehaviour {

	public Transform spawnPoint;

	public Transform bluebasic;
	public Transform bluewizard;
	public Transform bluecanon;
    
    public Transform bluechamp;
    
    
    
    private float countdown = 2f;
	public Text waveCountdownText;
	private int waveNum = 0;
    
    public Transform turretbluemele;
    public Transform turretbluewizard;
    public Transform turretbluecanon;
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
			SpawnBB();
			        yield return new WaitForSeconds(2.5f);
            SpawnBW();
                    yield return new WaitForSeconds(2.5f);
            SpawnBC();

		}
	}


	void SpawnBB(){ 
		Instantiate(bluebasic, spawnPoint.position, bluebasic.rotation);
	}
    void SpawnBW(){
    Instantiate(bluewizard, spawnPoint.position, bluewizard.rotation);
    }
    void SpawnBC(){
    Instantiate(bluecanon, spawnPoint.position, bluecanon.rotation);
    }
    
    
    void SpawnTurrets()
    {
    turretspositions = new Transform[transform.childCount];
		for (int i = 0; i < turretspositions.Length; i++) {
			turretspositions[i] = transform.GetChild(i);
            if(i>=0 && i<=1)
            Instantiate(turretbluecanon, turretspositions[i].position, turretbluecanon.rotation);
            if(i>=2 && i<=3)
            Instantiate(turretbluewizard, turretspositions[i].position, turretbluewizard.rotation);
            if(i>=4)
            Instantiate(turretbluemele, turretspositions[i].position, turretbluemele.rotation);  
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
