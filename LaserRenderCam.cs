using UnityEngine;
using System.Collections;

public class LaserRenderCam : MonoBehaviour {

	//empty gameobject with line renderer effect
	//conviene crear un material tipo particle
	// elementos tamaño y posiciones dan forma y complejidad a la linea
	// este script dentro del emptygameobject utilizara el component para crear el efecto deseado

	private LineRenderer lineRenderer;
	private  float counter;
	private  float distnce;

	public Transform origin;
	public Transform destination;

	public float lineSpeed = 15f;


	void start(){

		lineRenderer = GetComponent<LineRenderer>();
		lineRenderer.SetPosition(0, origin.position);
		lineRenderer.SetWidth(.45f, .45f);

		distnce = Vector3.Distance(origin.position, destination.position);
	}

	void update(){

		if(counter < distnce){

			counter+= .1f / lineSpeed;
			float x = Mathf.Lerp(0, distnce, counter);

			Vector3 pointa= origin.position;
			Vector3 pointb= destination.position;

			Vector3 pointAlongline = x * Vector3.Normalize(pointb-pointa)+pointa;
			lineRenderer.SetPosition(1, pointAlongline);	
		}

		if(counter == distnce)
		{
			//lineRenderer.material == detectedmaterial;
			Debug.Log("Focused");
		}


	}



}