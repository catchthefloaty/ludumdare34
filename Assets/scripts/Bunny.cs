using UnityEngine;
using System.Collections;

public class Bunny : actor {
    public Vector3 targetTest;
    public int speed = 2;
	// Use this for initialization
	override public  void Start () {
        base.Start();
        
	}
	
	// Update is called once per frame
	override public void Update () {
        base.Update();

	}


    public override void TurnOne()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetTest, step);
    }
}
