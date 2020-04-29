using UnityEngine;
using System.Collections;

/**
 * A class which represents behaviour of rotating around an object.
 */
public class RotateAround : MonoBehaviour {

	// the object to rotate around
	public Transform target; 
	// the speed of rotation
	public int speed; 
	
	/**
	 * Unity start function.It is called before any of the Update
	 * methods are called the first time.
	 */
	private void Start()
	{
		//If no target, do nothing
		if (target != null) return;
		//Else current object as the target
		target = this.gameObject.transform;
		//Output message
		Debug.Log ("RotateAround target not specified. Defaulting to parent GameObject");
	}

	// Update is called once per frame
	private void Update () {
		// RotateAround takes three arguments, first is the Vector to rotate around
		// second is a vector that axis to rotate around
		// third is the degrees to rotate, in this case the speed per second
		transform.RotateAround(target.transform.position,target.transform.up,speed * Time.deltaTime);
	}
}
