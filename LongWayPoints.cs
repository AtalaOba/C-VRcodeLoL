using UnityEngine;
using System.Collections;

public class LongWayPoints : MonoBehaviour {
	public static Transform[] longWayPoints;
	void Awake(){
		longWayPoints = new Transform[transform.childCount];
		for (int i = 0; i < longWayPoints.Length; i++) {
			longWayPoints[i] = transform.GetChild(i);
		}
	}
}
