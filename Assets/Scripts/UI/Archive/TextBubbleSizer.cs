using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBubbleSizer : MonoBehaviour 
{

	public Text TextBox;
	public GameObject BubbleImg;

	public RectTransform BubbleTransform;
	public RectTransform TextTransform;



	
	// Use this for initialization
	void Start () 
	{
		BubbleTransform = GetComponent<RectTransform>();
		TextTransform = TextBox.GetComponent<RectTransform>();

		//The following sets the size of the bubble to the size of the text box
		Vector2 TextSize = TextTransform.sizeDelta;
		Vector2 BubbleSize = BubbleTransform.sizeDelta;
		BubbleSize = new Vector2 (TextSize.x + 1, TextSize.y + 1);
		BubbleTransform.sizeDelta = BubbleSize;

		//This sets the height of the textbox - from http://answers.unity3d.com/questions/789561/46-ui-text-rect-does-not-expand-automatically.html
		TextTransform.sizeDelta = new Vector2(TextTransform.rect.width, TextBox.preferredHeight);


	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
