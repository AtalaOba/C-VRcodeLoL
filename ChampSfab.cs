using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[System.Serializable]
public class ChampSfab : MonoBehaviour {

	[Header("Object Info")]
	public GameObject prefab;
	public string name;

	[Header("Basic")]
	public float life;
	public float mana;
	[Header("Fight Atribs")]
	public float atds;
	public float atpw;
	public float atsp;
	public float mvsp;

	[Header("Habilities")]
	public string qSpell;
	public string wSpell;
	public string eSpell;
	public string rSpell;

	[Header("Summoner Spells")]
	public string dSpell;
	public string fSpell;

	[Header("Mastery")]

	public bool Masterystate;
	public string MasteryMainBranch;
	public int[] masteryelementvals;

	[Header("Items & Gold")]
	public ItemSfab listItems;
	public RuneSfab listRunes;
	public MaestrySfab listMaestry;
	public int gold;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
