using UnityEngine;

public class BuildManager : MonoBehaviour {

	public static BuildManager instance;

   // public GameObject standardTurretPrefab;
	//public GameObject missileLauncherPrefab;
	//public GameObject buildEffect;

	private TurretBlueprint turretToBuild;

	public Transform champloaderpos;


	private ChampSfab champselected;


	public bool CanBuild { get { return champselected != null; } }
	//public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }
	
	void Awake ()
	{
		if (instance != null)
		{
			Debug.LogError("More than one BuildManager in scene!");
			return;
		}
		instance = this;
	}	

	public void BuildTurretOn (Node node) // selecciona el punto donde aparece elcampeon, quizas no sea necesaria
	{
        /*
		if (PlayerStats.Money < turretToBuild.cost)
		{
			Debug.Log("Not enough money to build that!");
			return;
		}

		PlayerStats.Money -= turretToBuild.cost;
        
        */

		GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
		node.turret = turret;

		//GameObject effect = (GameObject)Instantiate(buildEffect, node.GetBuildPosition(), Quaternion.identity);
		//Destroy(effect, 5f);

		//Debug.Log("Turret build! Money left: " + PlayerStats.Money);
	}

	public void SelectChamp (ChampSfab champselected) // instacia el gameobject 
	{
		GameObject champ = (GameObject)Instantiate(champselected.prefab,champloaderpos.position,champloaderpos.rotation);

	}

}
