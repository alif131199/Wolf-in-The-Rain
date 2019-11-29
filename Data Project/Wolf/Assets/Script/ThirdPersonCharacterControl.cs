using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterControl : MonoBehaviour
{
    public float Speed;

	public int move = 0;

	Animator anim;

	void Start(){
		anim = GetComponent<Animator>();
	}

	void Update ()
    {
        PlayerMovement();
		if (Input.GetKey (KeyCode.W)){
			anim.SetInteger ("condition",1);
		}

		if (Input.GetKeyUp (KeyCode.W)){
			anim.SetInteger ("condition",0);
		}

		if (Input.GetKey (KeyCode.S)){
			anim.SetInteger ("condition",2);
		}

		if (Input.GetKeyUp (KeyCode.S)){
			anim.SetInteger ("condition",0);
		}

		if (Input.GetKey (KeyCode.A)){
			anim.SetInteger ("condition",3);
		}

		if (Input.GetKeyUp (KeyCode.A)){
			anim.SetInteger ("condition",0);
		}

		if (Input.GetKey (KeyCode.D)){
			anim.SetInteger ("condition",4);
		}

		if (Input.GetKeyUp (KeyCode.D)){
			anim.SetInteger ("condition",0);
		}

		if(anim.GetInteger("condition")>0){
			move = 1;
		}
		else{
			move = 0;
		}
    }

    void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(hor, 0f, ver) * Speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
    }
}