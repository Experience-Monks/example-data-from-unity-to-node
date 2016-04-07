using UnityEngine;
using System.Collections;

public class TestSendToExpress : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SendToExpress sender = this.GetComponent<SendToExpress> ();

		StartCoroutine(sender.SendJSON ("{\"test\": true}"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
