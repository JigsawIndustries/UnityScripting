using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Enemy {

	// Use this for initialization
 	public override void Yell()
	{
		base.Yell ();
		Debug.Log ("Orc version of the Yell() method");
	}

}
