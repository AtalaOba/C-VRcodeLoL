using UnityEngine;
using System.Collections;
using UnityEngine.UI;


[System.Serializable]
public class MaestrySfab : MonoBehaviour {

	[Header("Object Info")]
	public GameObject prefab;
	public string name;
	public int runeID;
	public Image item2Dicon;
	public int maestrylimit;

	[Header("Mains")]
	public string ferocidad;
	public string valor;
	public string astucia;


	[Header("Ferocidad Tab")]
	public bool elementfer;
	public int elementvaluefer;
	public float lifectrl;
	public int manactrl;
	public int goldctrl;
	public float attdst;
	public float attpwr;
	public float attsp;
	public float movspd;
	public float cooltim;

	[Header("Astucia Tab")]
	public bool elementast;
	public int elementvalueast;

	[Header("Valor Tab")]
	public bool elementval;
	public int elementvalueval;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



}
