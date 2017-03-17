using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour
{
    public float speedrun=250.0f;
    public float speedturn=4.0f;
    
    
    void Update()
    {
        /*if (!isLocalPlayer)
        {
            return;
        }*/
        
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speedrun;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speedturn;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
        
        if(z==0 &&x==0)
        {idle();}else{move();}

		if (Input.GetKeyDown("q"))
		{
			Attack1 ();
		}
    }
    
    public void move(){
			GetComponent<Animation>().Play("Run");
			Debug.Log ("move");

			}
	public void idle(){
			GetComponent<Animation>().Stop("Run");
			GetComponent<Animation>().Play("Idle");
			Debug.Log ("idle");
			}
	public void Attack1(){
		GetComponent<Animation>().Stop("Run");
		GetComponent<Animation>().Stop("Idle");
		//GetComponent<Animation>().Play("Attack1");
		Debug.Log ("Attaxk1");
	}
     public override void OnStartLocalPlayer()
    {
        //GetComponent<Animation>().Play("TrundleRun");
         Debug.Log("Online Bitch");
    }
}
