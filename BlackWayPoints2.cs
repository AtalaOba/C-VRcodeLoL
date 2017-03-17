using UnityEngine;
using System.Collections;

public class BlackWayPoints2 : MonoBehaviour {
	public static Transform[] blackWayPoints2;
	void Awake(){
		blackWayPoints2 = new Transform[transform.childCount];
				for (int i = 0; i < blackWayPoints2.Length; i++) {
					blackWayPoints2[i] = transform.GetChild(i);
				}
	}
}
