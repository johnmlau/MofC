using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class JamesTyper : MonoBehaviour 
{
	public Text Textbox;
	private string[] TextArray = new string[3] {"Hello", "What is it?", "Bloody hell my life is over"}; 
	private int CurrentText = 0;

	public GameObject Chatbox;
	private ChatBubbleController ChatController;
	
	// Use this for initialization
	void Start () 
	{
		ChatController = Chatbox.GetComponent<ChatBubbleController>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (Input.GetKeyDown (KeyCode.A)) 
		{
			CurrentText = 0;
			//WriteText (CurrentText);
			WriteText ();
		}
		
		if (Input.GetKeyDown (KeyCode.S)) 
		{
			CurrentText = 1;
			WriteText ();
		}
		
		if (Input.GetKeyDown (KeyCode.D)) 
		{
			CurrentText = 2;
			WriteText ();
		}
	}

	public void WriteText ()
	{
		Textbox.text = TextArray [CurrentText];

		if (CurrentText < TextArray.Length) 

		{
			ChatController.JamesChat ();
			CurrentText +=1;
		}




	}


}
