using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetControl : MonoBehaviour
{
    Animator anim;
	int gauge = 0;
	int back = 0;
	public GameObject player;
	public GameObject alert;

    void Start()
    {
	anim = GetComponent<Animator>();
	alert.GetComponent<Renderer>().material.color = Color.green;
    }

    void Update()
    {

	gauge+=Random.Range(0,10);


     if (gauge>=900){
			anim.SetInteger("aware",1);
			//transform.Rotate(0,180,0);
		}
	  if(gauge>=1000 && back == 0){
	  	  back = 1;
	  }

	  if (gauge>=2000){
			anim.SetInteger("aware",0);
			//transform.Rotate(0,180,0);
			gauge = 0;
			back = 0;
		}


		if(player.GetComponent<ThirdPersonCharacterControl>().move == 1 && back == 1){
			//alert.GetComponent<Renderer>().material.color = Color.red;
			SceneManager.LoadScene ("GameOver");
		}

		if(back == 0){
			//alert.GetComponent<Renderer>().material.color = Color.green;
		}
		
    }

	void OnCollisionEnter(Collision collisionInfo){
		if(collisionInfo.collider.tag == "Player"){
			//alert.GetComponent<Renderer>().material.color = Color.red;
			SceneManager.LoadScene ("Win");
		}
	}
}
