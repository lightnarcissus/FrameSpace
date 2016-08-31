using UnityEngine;
using System.Collections;

public class FramePushback : MonoBehaviour {
	public bool active = false;
	public GameObject audioObj;
	public GameObject textObj;

	public Vector3 audioStartPos=new Vector3(23.306f,0.26f,44.01f);
	public Vector3 audioEndPos=new Vector3(23.09f,0.26f,44.01f);

	public Vector3 textStartPos=new Vector3(23.209f,0.26f,44.01f);
	public Vector3 textEndPos=new Vector3(23.429f,0.26f,44.01f);
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(!active)
		{
			//active = true;
			//GetComponent<BoxCollider2D>().size += Vector2.one * 0.01f;
			if (audioObj.transform.localScale.x <= 0.45f) {
				audioObj.transform.localScale += new Vector3 (0.01f, 0f, 0f);
				float ok = 1f - (1f / (0.45f - audioObj.transform.localScale.x));
				audioObj.transform.localPosition = Vector3.Lerp (audioEndPos, audioStartPos, ok);
			}

			if (textObj.transform.localScale.x <= 0.45f) {
				textObj.transform.localScale += new Vector3 (0.01f, 0f, 0f);
				float oktext = 1f - (1f / (0.45f - textObj.transform.localScale.x));
				textObj.transform.localPosition = Vector3.Lerp (textEndPos, textStartPos, oktext);
			}
//
//			if (GetComponent<BoxCollider2D>().size.x >= 1f)
//				GetComponent<BoxCollider2D>().size -= Vector2.one * 0.01f;
//			if (audioObj.transform.localScale.x >= 1f)
//				audioObj.transform.localScale -= Vector3.one * 0.01f;
//			audioObj.transform.localScale = new Vector3(audioObj.transform.localScale.x, audioObj.transform.localScale.y, 44.2f);
//
//			if (textObj.transform.localScale.x >= 1f)
//				textObj.transform.localScale -= Vector3.one * 0.01f;
//			textObj.transform.localScale = new Vector3(textObj.transform.localScale.x, textObj.transform.localScale.y, 44.2f);
	}
	}

	void OnMouseDrag()
	{
		active = true;

		if(audioObj.transform.localScale.x >=0.01f)
			audioObj.transform.localScale -= new Vector3(0.01f,0f,0f);
		float ok = 1f - (0.45f / (0.45f-audioObj.transform.localScale.x));
		Debug.Log (ok);
		audioObj.transform.localPosition = Vector3.Lerp (audioStartPos,audioEndPos, ok);

		if(textObj.transform.localScale.x >=0.01f)
			textObj.transform.localScale -= new Vector3(0.01f,0f,0f);
		float oktext = 1f - (1f / (textObj.transform.localScale.x-0.01f));
		textObj.transform.localPosition = Vector3.Lerp (textStartPos,textEndPos, oktext);


	}
	void OnMouseUp()
	{
		active = false;
	}
}