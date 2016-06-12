using UnityEngine;
using System.Collections;

public class FrameExpand : MonoBehaviour {
    public bool active = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        	if(!active)
        {

            if (GetComponent<BoxCollider2D>().size.x >= 1f)
                GetComponent<BoxCollider2D>().size -= Vector2.one * 0.01f;
            if (transform.localScale.x >= 1f)
                transform.localScale -= Vector3.one * 0.01f;
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, 44.2f);
        }
	}

    void OnMouseOver()
    {
        active = true;
        GetComponent<BoxCollider2D>().size += Vector2.one * 0.01f;
		transform.localScale += Vector3.one * 0.01f;
		//transform.localScale+= new Vector3(0.01f, transform.localScale.y, transform.localScale.z);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, 44.05f);

    }
    void OnMouseExit()
    {
        active = false;
    }
}
