using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextTyper : MonoBehaviour 

{
	public Text Textbox;
	private string[] TextArray = new string[3] {"I have some news for you", "You really need to hear it, I'm serious, James.", "I'm three months gone and I'm keeping it. I hope you can afford child support, big guy."}; 
	private int CurrentText = 0;
	public float TypeDelay = 0.1f;
	public GameObject Chatbox;
	private ChatBubbleController ChatController;

	// Use this for initialization
	void Start () 
	{
		Textbox = GetComponent<Text>();
		ChatController = Chatbox.GetComponent<ChatBubbleController>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (Input.GetKeyDown (KeyCode.Q)) 
		{
			CurrentText = 0;
			StartCoroutine (AnimateText ());
		}

		if (Input.GetKeyDown (KeyCode.W)) 
		{
			CurrentText = 1;
			StartCoroutine(AnimateText());
		}
		
		if (Input.GetKeyDown (KeyCode.E)) 
		{
			CurrentText = 2;
			StartCoroutine(AnimateText());
		}
	}



//This is the typewriter function
	IEnumerator AnimateText()
	{
		for (int i = 0; i<(TextArray[CurrentText].Length+1); i++) 
		{
			Textbox.text = TextArray[CurrentText].Substring(0,i);
			yield return new WaitForSeconds (TypeDelay);
		}
		//hits 'send' and makes the bubble appear
		Textbox.text = "";
		ChatController.RosChatText.text = TextArray [CurrentText]; // this changes the content of the text in Ros' bubble
		ChatController.RosChat ();

	
	}

}
