using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class water : MonoBehaviour {
    public List<Sprite> frames;
    public float animRate;
    float animTime;
    int curFrame;




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        animTime += Time.deltaTime;
        if(animTime > animRate)
        {
            animTime = 0;
            curFrame += 1;
            if (curFrame >= frames.Count)
            {
                curFrame = 0;

            }
            GetComponent<SpriteRenderer>().sprite = frames[curFrame];
        }

	}


}
