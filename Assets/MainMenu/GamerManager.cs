using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamerManager : MonoBehaviour {

    public Text usernameText;
	// Use this for initialization
	void Start()
    {
        usernameText.text = GlobalControl.Instance.email;
    }
	// Update is called once per frame
	void Update () {
        usernameText.text = GlobalControl.Instance.email;
    }
}
