using UnityEngine;
using System.Collections;

public class BushSpawner : MonoBehaviour {
    
    public static Transform[] bushpositions;
    public Transform bushunit;
	// Use this for initialization
    
    void Awake (){
        SpawnBushes();
    }
	

    
    void SpawnBushes(){
        bushpositions = new Transform[transform.childCount];
        for (int i = 0; i < bushpositions.Length; i++) {
			bushpositions[i] = transform.GetChild(i);
            Instantiate(bushunit, bushpositions[i].position, bushunit.rotation);
        
    }
}
    
}
