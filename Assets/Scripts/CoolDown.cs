using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CoolDown : MonoBehaviour 

{

	public Image image;
	private float WaitTime = 2f;

	public GameObject Default = null;
	public GameObject Panel = null;
	
	void Start()
	{
		image = gameObject.GetComponent<Image>();
	}
	
	void Update () 
	{
		image.fillAmount -= 1.0f/WaitTime * Time.deltaTime;

		if (image.fillAmount <= 0) 
		{
			Default.SetActive(true);
			Panel.SetActive (false);
			Reset ();

		}
	}
	
	public void Reset ()
		
	{
		image.fillAmount = 1f;
	}
}
