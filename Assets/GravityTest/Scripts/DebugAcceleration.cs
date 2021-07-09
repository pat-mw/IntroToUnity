using UnityEngine;
using UnityEngine.UI;
using System.Collections;


[RequireComponent(typeof(Text))]
public class DebugAcceleration : MonoBehaviour
{
	private Text text;

	void Start()
	{
		text = this.GetComponent<Text>();
	}

	// Update is called once per frame
	void Update()
	{
		string debugStr = $"X: {Input.acceleration.x} \n Y: {Input.acceleration.y} \n Z: {Input.acceleration.z}";
		text.text = debugStr;
	}
}