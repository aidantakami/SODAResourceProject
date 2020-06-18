using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeManipulationScript : MonoBehaviour
{

	//Serialized SODA Fields
	[SerializeField] private FloatReference cubeRotationSpeed;
	[Tooltip ("Must be between 0 and 100")]
	[SerializeField] private FloatReference deathProbability;

	private float randomTemp;

	void Update ()
	{

		//Rotate the Cube
		transform.Rotate (new Vector3 ((cubeRotationSpeed * Time.deltaTime), 0, 0));

	}

	//Event Responses
	#region 

	//Cube's response to the KillEvent
	public void CubeKillEventResponse ()
	{
		randomTemp = Random.Range (0f, 100f);

		if (randomTemp < Mathf.Clamp (deathProbability, 0, 100))
		{
			gameObject.GetComponent<MeshRenderer> ().enabled = false;
		}
	}

	//Cube's response to SpinNumber Parameterized Event
	public void CubeSpinEventResponse (float spinTime)
	{
		//Starts spinning coroutine
		StartCoroutine (CubeSpinCoroutine (spinTime));
	}

	//Coroutine to manage horizontal spin of cube
	private IEnumerator CubeSpinCoroutine (float spinNumber)
	{
		//Temp used to manage the end of rotation
		float timePassed = 0f;

		while (timePassed < spinNumber)
		{
			//Rotate the Cube
			transform.Rotate (new Vector3 (0, 0, cubeRotationSpeed * Time.deltaTime));

			//Increment
			timePassed += Time.deltaTime;

			//Wait for end of frame
			yield return new WaitForEndOfFrame ();
		}
	}

	//Revival Response
	public void RespawnCube ()
	{
		//Respawns cube
		gameObject.GetComponent<MeshRenderer> ().enabled = true;
	}

	#endregion

}