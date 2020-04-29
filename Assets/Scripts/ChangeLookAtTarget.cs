using UnityEngine;

/**
 * A class which represents the behaviour of setting camera to look at an object
 * when we click the mouse's left button while over the Collider.
 */
public class ChangeLookAtTarget : MonoBehaviour {

	//A static field, indicates the target we want to look at
	//and the target that the camera should follow
	public GameObject target; 

	/**
	 * Unity Start function.It is called before any of the Update
	 * methods are called the first time.
	 */
	private void Start ()
	{
		//If no target, do nothing
		if (target != null) return;
		//Else set the current gameObject as target
		target = gameObject;
		Debug.Log ("ChangeLookAtTarget target not specified. Defaulting to parent GameObject");
	}

	/**
	 * OnMouseDown is called when the user has pressed the mouse's left button while over the Collider.
	 */
	private void OnMouseDown () {
		// change the target of the FollowAtTarget script to be this gameObject.
		FollowAtTarget.target = target;
		// change the field of view on the perspective camera based on the distance from center of world,
		// clamp it to a reasonable field of view
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 100);
	}
}
