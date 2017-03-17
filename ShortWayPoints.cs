using UnityEngine;
using System.Collections;

public class ShortWayPoints : MonoBehaviour {
	public static Transform[] shortWayPoints;
	void Awake(){
		shortWayPoints = new Transform[transform.childCount];
		for (int i = 0; i < shortWayPoints.Length; i++) {
			shortWayPoints[i] = transform.GetChild(i);
		}
	}
}
