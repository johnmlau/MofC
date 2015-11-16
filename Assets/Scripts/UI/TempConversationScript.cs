using UnityEngine;
using System.Collections;

public class TempConversationScript : MonoBehaviour 
{

	public ChatBubbleController ChatBubble;

	// Use this for initialization
	void Start () 
	{
		ChatBubble = GetComponent<ChatBubbleController> ();
		/*
		if (CurrentText < TextArray.Length) 
		{
			CurrentText += 1;
			//StartCoroutine (AnimateText ()); Oh it's trying to get James Typer before it exists
			jamesType = ChatController.JamesBubble.gameObject.GetComponent<JamesTyper>();
			print ("got JamesTyper");
			//jamesType.WriteText ();
			
		}
		*/
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			//Need to find a way of activating a series of bubbles to simulate a conversation.
		}


	}
}
