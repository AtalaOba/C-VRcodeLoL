using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[System.Serializable]
public class ItemSfab : MonoBehaviour {
	
	[Header("Object Info")]
	public GameObject prefab;
	public string name;
	public int itemID;
	public Image item2Dicon;

	[Header("Basic")]
	public int cost;
	public string desc;

	[Header("Fight Atribs")]
	public float lifectrl;
	public int manactrl;
	public int goldctrl;
	public float attdst;
	public float attpwr;
	public float attsp;
	public float movspd;
	public float cooltim;

	[Header("Item Spells")]
	public Transform itemActive;
	public Transform itemPasive;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
