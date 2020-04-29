using UnityEngine;

/**
 * A class which represents behaviour of rotating around an object.
 */
public class RotateAround : MonoBehaviour {

	// the object to rotate around
	public Transform target; 
	// the speed of rotation
	public int speed; 
	
	/**
	 * Unity Start function.It is called before any of the Update
	 * methods are called the first time.
	 */
	private void Start ()
	{
		//If no target, do nothing
		if (target != null) return;
		//Else set current object's transform component as the target
		target = gameObject.transform;
		//Output message
		Debug.Log ("RotateAround target not specified. Defaulting to parent GameObject");
	}

	/**
	 * Unity Update function, called once per frame
	 */
	private void Update () {
		// RotateAround takes three arguments, first is the Vector to rotate around
		// second is a vector that axis to rotate around
		// third is the degrees to rotate, in this case the speed per second
		transform.RotateAround(target.transform.position,target.transform.up,speed * Time.deltaTime);
	}
}
