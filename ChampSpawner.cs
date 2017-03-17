using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChampSpawner : MonoBehaviour {
	
	// public GameObject standardTurretPrefab;
	//public GameObject missileLauncherPrefab;
	//public GameObject buildEffect;
	//private TurretBlueprint turretToBuild;

	//public static ChampSpawner instance;
	//ChampSpawner champspawner;
	//string champname="";
	//private ChampSfab champselected;



	public Transform champloaderpos;
	//public Transform canvaspos;


	//public Canvas canvaschamp;

	GameObject canvasprev=null;
	GameObject canvasload=null;
	public int canvload;

	GameObject modelprev= null;
	GameObject modeload=null;
	public int champload=0;

	//public bool CanChoose { get { return champselected != null; } }
	//public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }


	/*
	void Awake ()
	{
		if (instance != null)
		{
			Debug.LogError("More than one BuildManager in scene!");
			return;
		}
		instance = this;
	}	

	void Start ()
	{
		
		//champspawner = ChampSpawner.instance;
	}

	void Update(){

		//gameObject.SetActiveRecursively (false);
	} */

	public void SpawnChamp(GameObject champmodel) {
		if (champload==0) 
		{
			modeload = (GameObject)Instantiate(champmodel, champloaderpos.position, champloaderpos.rotation);
			champload = 1;
			//champname = champmodelname.name;
			modelprev = modeload;
		}

		else
		{
			if (champmodel.name == modelprev.name) 
			{
				Debug.Log (champmodel.name+" == "+modelprev.name+" asi que borraremos:"+champmodel.name);
				modeload = GameObject.Find (modeload.name);
				Destroy (champmodel);
				champload = 0;
			}

			if (champmodel.name != modelprev.name) 
			{
				Debug.Log (champmodel.name+" != "+modelprev.name+" asi que borraremos:"+modelprev.name+" y crearemos:"+champmodel.name);
				modelprev = GameObject.Find (modelprev.name);
				Destroy (modelprev);
				modeload = (GameObject)Instantiate(champmodel, champloaderpos.position, champloaderpos.rotation);
				modelprev = modeload;
				champload = 1;
			}
		}
	}


	public void SpawnCanvas(GameObject canvaschamp)
	{
		if (canvload==0) 
		{
			//canvaschamp.SetActive = true;
			canvasload = (GameObject)Instantiate(canvaschamp, champloaderpos.position, champloaderpos.rotation);
			canvload = 1;
			//champname = champmodelname.name;
			canvasprev = canvasload;
		}

		else
		{
			if (canvaschamp == canvasprev) 
			{
				Debug.Log (canvaschamp.name+" == "+canvasprev.name+" asi que borraremos:"+canvaschamp.name);
				canvasload = GameObject.Find (canvasload.name);
				Destroy (canvaschamp);
				canvload = 0;
			}

			if (canvaschamp.name != canvasprev.name) 
			{
				Debug.Log (canvaschamp.name+" != "+canvasprev.name+" asi que borraremos:"+canvasprev.name+" y crearemos:"+canvaschamp.name);
				canvasprev = GameObject.Find (canvasprev.name);
				Destroy (canvasprev);
				canvasload = (GameObject)Instantiate(canvaschamp, champloaderpos.position, champloaderpos.rotation);
				canvasprev = canvasload;
				canvload = 1;
			}
		}
	} 

	/*
	public void SpawnAatrox ()
	{ 
		if (Aatroxload==0) {
			//Destroy(gameObject);
			GameObject champatrox = (GameObject)Instantiate (Aatrox, champloaderpos.position, champloaderpos.rotation);
			Aatroxload = 1;
			return;
		} 
		else
		{
			Debug.Log ("Loaded");
			GameObject champ = GameObject.Find("Aatrox(Clone)");
			Destroy (champ);
			Aatroxload = 0;
		}

	}
	public void SpawnTrundle ()
	{
		if (Trundleload==0) {
			//Destroy(gameObject);
			GameObject champtrundle = (GameObject)Instantiate(Trundle,champloaderpos.position,champloaderpos.rotation);
			Trundleload = 1;
			return;
		} 
		else 
		{
			Debug.Log ("Loaded");
			GameObject champ = GameObject.Find("Trundle(Clone)");
			Destroy (champ);
			Trundleload = 0;
		}



	}
	*/

}