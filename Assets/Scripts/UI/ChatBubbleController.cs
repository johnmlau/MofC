using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChatBubbleController : MonoBehaviour 

	{

	public GameObject JamesBubble;
	public GameObject RosBubble;
	public GameObject Spawnloc;
	public Transform ChatCanvas;
	private float ChatVertOffset = 75f;
	private Vector3 ChatHorzOffset;
	public GameObject ScrollLimit;

	public Text RosChatText;

	public Text JamesBubbleText;


	// Use this for initialization
	void Start () 
	{
		ChatHorzOffset = new Vector3 (20,0,0);

	}
	
	// Update is called once per frame
	void Update () 
	
	{
		if (Input.GetKeyDown (KeyCode.Space))
			JamesChat ();
	
	}

	public void RosChat()
	{
		GameObject chatbubble = Instantiate (JamesBubble, (Spawnloc.transform.position + ChatHorzOffset),Quaternion.identity) as GameObject; 
		//Preceding method is so that we can keep a hold of the information associated with the new instantiated object, which we do because of the transform command in the next line
		chatbubble.transform.SetParent (ChatCanvas.transform);
		Spawnloc.transform.position -= new Vector3 (0,ChatVertOffset,0);

		if (Spawnloc.transform.position.y <= ScrollLimit.transform.position.y) 
		{
			ChatCanvas.transform.position += new Vector3 (0, ChatVertOffset, 0);
		}

	}

	public void JamesChat()
	{
		GameObject chatbubble = Instantiate (RosBubble, (Spawnloc.transform.position - ChatHorzOffset), Quaternion.identity) as GameObject; 
		//Preceding method is so that we can keep a hold of the information associated with the new instantiated object, which we do because of the transform command in the next line
		chatbubble.transform.SetParent (ChatCanvas.transform);
		Spawnloc.transform.position -= new Vector3 (0, ChatVertOffset, 0);
	
		if (Spawnloc.transform.position.y <= ScrollLimit.transform.position.y) {
			ChatCanvas.transform.position += new Vector3 (0, ChatVertOffset, 0);
		}

	}

}
