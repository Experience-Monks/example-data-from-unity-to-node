using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SendToExpress : MonoBehaviour {

	public string url = "http://localhost:8080";

	public IEnumerator SendJSON(string jsonString) {
		Debug.Log ("SEND: " + jsonString);

		System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
		System.Collections.Generic.Dictionary<string, string> postHeader = new System.Collections.Generic.Dictionary<string, string> ();

		postHeader.Add("Content-Type", "text/json");
		postHeader.Add("Content-Length", jsonString.Length.ToString());

		WWW request = new WWW(url, encoding.GetBytes(jsonString), postHeader);

		Debug.Log ("SENDING");

		yield return request;

		// Print the error to the console
		if (request.error != null)
		{
			Debug.Log("request error: " + request.error);
		}
		else
		{
			Debug.Log("request success");
			Debug.Log("returned data: " + request.text);
		}
	}
}
