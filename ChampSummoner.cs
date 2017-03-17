using UnityEngine;
using System.Collections;

public class ChampSummoner : MonoBehaviour {

	public Transform GolemSpell;
    public Transform DragonSpell;
    public Transform MinionSpell;
    public Transform spawnspell;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
        Instantiate(GolemSpell, spawnspell.position, spawnspell.rotation);
        }
        
        if (Input.GetMouseButtonDown(1))
        {
         Instantiate(DragonSpell, spawnspell.position, spawnspell.rotation);
        }
        
        if (Input.GetMouseButtonDown(2))
        {
         Instantiate(MinionSpell, spawnspell.position, spawnspell.rotation);
        }
	
	}
}
