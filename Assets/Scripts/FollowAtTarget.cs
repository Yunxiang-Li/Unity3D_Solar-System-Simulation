using UnityEngine;

/**
 * A class which represents the behaviour of setting camera to aim at an object's positive z axis direction.
 */
public class FollowAtTarget : MonoBehaviour {
	
	// the target that the camera should look at
	public static GameObject target; 

	/**
	 * Unity Start function.It is called before any of the Update
	 * methods are called the first time.
	 */
	private void Start ()
	{
		//If no target, do nothing
		if (target != null) return;
		//Else set the current gameObject(main camera) as target
		target = gameObject;
		Debug.Log ("LookAtTarget target not specified. Defaulting to parent GameObject");
	}
	
	/**
	 * Unity Update function, called once per frame
	 */
	private void Update () {
		//If there is a target, the camera will always aim at its positive z axis direction
		if (target)
			transform.LookAt(target.transform);
	}
}
