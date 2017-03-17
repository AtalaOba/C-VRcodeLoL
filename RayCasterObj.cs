using UnityEngine;
using System.Collections;

public class RayCasterObj : MonoBehaviour {
	public Camera camera;
	//public Transform Minion;
	//public Transform MinionExplosion;
	public Transform Pointer;
	//public bool selectionstate;
	//public Movement _movement;
	//public Canvas _Canvas;

	void Update(){
		RaycastHit hit;
		float DistanceTo;
		float PositionOf;


		Vector3 forward = transform.TransformDirection (Vector3.forward) * 500;

		Ray ray = camera.ScreenPointToRay(Input.mousePosition);

		Debug.DrawRay(transform.position,forward,Color.green);

		if(Physics.Raycast(transform.position,(forward),out hit)){
			DistanceTo = hit.distance;
            print (DistanceTo + " " + hit.collider.gameObject.name);
            //if (Input.GetButtonDown ("Fire1")) {
            //Instantiate (Pointer, hit.point, Pointer.transform.rotation);
            //}
                //if (hit.collider.gameObject.tag == "ZyraThornPlant") {
					//selectionstate = true;
					//_movement.move ();
					//Debug.Log ("PlantClicked on position" + hit.point);
					//}
                //if (hit.collider.gameObject.name == "ThirdPersonController")
                    //_movement.idle ();
			
		}
	}

}

/*
//Light raylight = hit.collider.gameObject.AddComponent <Light>() as Light;
//siwtch with list or dictionare using a int key with a champion or object tag 
// With script movement we will send to states from ray caster object

/*switch (hit.collider.gameObject.name) {
				case "ShopIdlefbxA": 
					Debug.Log("Tienda")
					break;
				default:
					Debug.Log("Switch scanning");
					break;
				}

*/

/*if (Input.GetButtonDown ("Fire1")) {
					if (hit.collider.gameObject.name == "sand") {
					selectionstate = false;
					Debug.Log("Floor Targeted on " + hit.point );
					Instantiate (Pointer, hit.point, Pointer.transform.rotation);
					Instantiate(Minion,hit.point, Minion.transform.rotation);
					Instantiate(MinionExplosion,hit.point, transform.rotation);
					Debug.Log("Not Champ Selected");
					_movement.move ();
					}
					if ((hit.collider.gameObject.tag == "RedChamp") || (hit.collider.gameObject.tag == "BlueChamp")) {
					selectionstate = true;
					_movement.idle ();
					Debug.Log ("ChampClicked on position" + hit.point);
					}

			
			}

*/