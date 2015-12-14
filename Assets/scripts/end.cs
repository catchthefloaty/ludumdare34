using UnityEngine;
using System.Collections;

public class end : MonoBehaviour {
    public string ending;
	// Use this for initialization
	void Start () {
        Object.DontDestroyOnLoad(gameObject);

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
	}
}
