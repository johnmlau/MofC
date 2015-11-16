using UnityEngine;
using System.Collections;

public class DecisionScript : MonoBehaviour 
{
	public GameObject DecisionPanel = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Return)) 
		{
			DecisionPanel.SetActive (true);
		}

	}
}
