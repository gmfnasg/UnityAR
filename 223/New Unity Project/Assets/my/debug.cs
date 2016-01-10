using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class debug : MonoBehaviour {

    public Text logtext;
    public Camera camera;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (logtext != null && camera != null)
        {
            logtext.text = camera.gameObject.transform.position.ToString();
        }
	}
}
