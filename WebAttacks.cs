using UnityEngine;
using System.Collections;

public class WebAttacks : MonoBehaviour {

	public string url = "https://lolstatic-a.akamaihd.net/champion-abilities/videos/mp4/0266_01.mp4";

	IEnumerator loadAndPlay(){
		WWW diskMovieDir = new WWW(url);

		yield return diskMovieDir;


		//Save the loaded movie from WWW to movetexture
		MovieTexture movieToPlay = diskMovieDir.movie;

		//Hook the movie texture to the current renderer
		MeshRenderer ren = GetComponent<MeshRenderer>();
		ren.material.mainTexture = movieToPlay ;    

		movieToPlay.Play();
	}


}
