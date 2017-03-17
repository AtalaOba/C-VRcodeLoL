using UnityEngine;
using System.Collections;

public class BlackWayPoints : MonoBehaviour {
	public static Transform[] blackWayPoints;
	void Awake(){
		blackWayPoints = new Transform[transform.childCount];
		for (int i = 0; i < blackWayPoints.Length; i++) {
			blackWayPoints[i] = transform.GetChild(i);
		}
	}
}
