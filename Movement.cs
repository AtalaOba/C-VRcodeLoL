using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public RayCasterObj _RayCasterObj;
	public Transform champ;
	private float champrotmov=15.0f;


	public void move(){
			GetComponent<Animation>().Play("ZyraThornAttack");
			Debug.Log ("move");

			}
	public void idle(){
			GetComponent<Animation>().Stop("ZyraThornAttack");
			GetComponent<Animation>().Play("ZyraThornIdle");
			Debug.Log ("idle");
			}
}
/* 
 else {
			GetComponent<Animation>().Play("TrundleIdle");
			Debug.Log ("Champ Movement on click floor");
		}



*/