using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Vuforia;

public class debug : MonoBehaviour {

    public Text logtext;
    public Camera camera;
    
	// Use this for initialization
	void Start () {
        CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_MACRO);
	}
	
	// Update is called once per frame
	void Update () {
        if (logtext != null && camera != null)
        {
            logtext.text = camera.gameObject.transform.position.ToString();
        }
	}
}
