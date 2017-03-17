using UnityEngine;
using System.Collections;

public class ComponentAccess : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static T AccessComponentEvent<T>(string nameGameObject) where T: UnityEngine.Component
	{
		GameObject controller = GameObject.Find(nameGameObject);
		if (controller != null) {
			return controller.GetComponent<T> ();
		} else {
			Debug.Log("No se ha encontrado el portal");
			return null;
		}


	}
}

