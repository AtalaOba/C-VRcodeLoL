using UnityEngine;
using System.Collections;

public class SHOT : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		GetComponent<Rigidbody>().AddForce (transform.forward * 6000);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) 
	{
		if (other.name == "Floor") {
			Destroy (gameObject, 1);
		
		} 
		else if (other.tag == "ENEMIEEGG") 
		{
			Destroy (gameObject, 1);
			other.SendMessage ("EggDestroy", SendMessageOptions.DontRequireReceiver);
		} 
		else if (other.tag == "DRAGONAIRATTACK") 
		{
			Destroy (gameObject, 1);
			other.SendMessage ("DragonDestroy", SendMessageOptions.DontRequireReceiver);
			
		}
		else if (other.tag == "BOSSDRAGON") 
		{
			Destroy (gameObject, 1);
			other.SendMessage ("BossDragonDestroy", SendMessageOptions.DontRequireReceiver);
		} 
}

}