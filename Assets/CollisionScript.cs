using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
	public GameObject Spawn1;
	public GameObject Player;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.y<0){
        	Player.transform.position = Spawn1.transform.position;
    		Player.transform.rotation = Spawn1.transform.rotation;
    		Debug.Log("entered");
        }
    }

    private void OnTriggerEnter(Collider other){
    	Player.transform.position = Spawn1.transform.position;
    	Player.transform.rotation = Spawn1.transform.rotation;
    	Debug.Log("entered");
    }
}
