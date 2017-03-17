using UnityEngine;

public class Shop : MonoBehaviour {
	
	public TurretBlueprint standardTurret;
	public TurretBlueprint missileLauncher;
	private ChampSfab champselected;
	BuildManager buildManager;

	void Start ()
	{
		buildManager = BuildManager.instance;
	}

	public void ShopGolem ()
	{
		Debug.Log("Golem Shop");
		buildManager.SelectChamp(champselected);
	}

	public void ShopDragon()
	{
		Debug.Log("Dragon Shop");
		buildManager.SelectChamp(champselected);
	}
	

}
