using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AwaySwitcher : MonoBehaviour 
	{
	public GameObject[] Cameras;


	// Use this for initialization
	void Start () 
	
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		if (Input.GetKeyDown (KeyCode.Alpha1))
				SwitchDialogue (0);
			
		if (Input.GetKeyDown (KeyCode.Alpha2))
			SwitchDialogue (1);
			
		if (Input.GetKeyDown (KeyCode.Alpha3))
			SwitchDialogue (2);
			
		if (Input.GetKeyDown (KeyCode.Alpha4))
			SwitchDialogue (3);
			
		if (Input.GetKeyDown (KeyCode.Alpha5))
			SwitchDialogue (4);
			
		if (Input.GetKeyDown (KeyCode.Alpha6))
			SwitchDialogue (5);
			
		if (Input.GetKeyDown (KeyCode.Alpha7))
			SwitchDialogue (6);
			
	
	}

	public void SwitchDialogue (int LineNum)
	{
		foreach (GameObject GO in Cameras) {
			GO.SetActive (false);
		}
		Cameras[LineNum].SetActive(true);
	}
}
