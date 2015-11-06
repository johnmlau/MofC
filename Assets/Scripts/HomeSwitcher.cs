using UnityEngine;
using System.Collections;

public class HomeSwitcher : MonoBehaviour 
{

	public GameObject[] Cameras;


	// Use this for initialization
	void Start () 
	{


	}
	
	// Update is called once per frame
	void Update () 

	{
	if (Input.GetKeyDown (KeyCode.Keypad1)) 
		{
			SwitchCam (0);
		}

	if (Input.GetKeyDown (KeyCode.Keypad2))
		{
			SwitchCam (1);
		}

	if (Input.GetKeyDown (KeyCode.Keypad3))
		{
			SwitchCam (2);
		}

		if (Input.GetKeyDown (KeyCode.Keypad4))
		{
			SwitchCam (3);
		}

	if (Input.GetKeyDown (KeyCode.Keypad5))
		{
			SwitchCam (4);
		}

		if (Input.GetKeyDown (KeyCode.Keypad6))
		{
			SwitchCam (5);
		}

	if (Input.GetKeyDown (KeyCode.Keypad7)) 
		{
			SwitchCam (6);
		}
	}

	public void SwitchCam (int CamNum)
	{
		foreach (GameObject GO in Cameras) {
			GO.SetActive (false);
		}
		Cameras[CamNum].SetActive(true);
	}
}
