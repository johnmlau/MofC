using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChatBubbleController : MonoBehaviour 

	{

	public RectTransform JamesBubble;
	public RectTransform RosBubble;
	
	public Transform Spawnloc;
	public GameObject ScrollLimit;

	public Transform ChatCanvas;
	private float ChatVertOffset = 10f;
	private Vector3 ChatHorzOffset;

	public Text RosChatText;
	public Text JamesBubbleText;

	private Rect BubbleRect;


	// Use this for initialization
	void Start () 
	{
		ChatHorzOffset = new Vector3 (20,0,0);

	}
	
	// Update is called once per frame
	void Update () 
	
	{

	}

	public void RosChat()
	{
		StartCoroutine (CreateNewBubble(RosBubble, ChatHorzOffset));
	}

	public void JamesChat()
	{
		StartCoroutine (CreateNewBubble(JamesBubble, -ChatHorzOffset));
	}


	private IEnumerator CreateNewBubble (RectTransform bubblePrefab, Vector3 horizontalOffset)
	{
		RectTransform newBubble = Instantiate(bubblePrefab, (Spawnloc.position + horizontalOffset), Quaternion.identity) as RectTransform;
		
		//Preceding method is so that we can keep a hold of the information associated with the new instantiated object, which we do because of the transform command in the next line
		newBubble.SetParent (ChatCanvas.transform);

		yield return new WaitForEndOfFrame ();

		float moveAmount = newBubble.rect.height + ChatVertOffset;
	
		Spawnloc.position -= moveAmount * Vector3.up;

		//The following only scrolls the chat up once you've got past a certain point (ScrollLimit)
		if (Spawnloc.position.y <= ScrollLimit.transform.position.y)
		{
			ChatCanvas.transform.position += moveAmount * Vector3.up;
		}
	}
}
