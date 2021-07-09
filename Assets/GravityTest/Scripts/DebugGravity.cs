using UnityEngine;
using UnityEngine.UI;
using System.Collections;


[RequireComponent(typeof(Text))]
public class DebugGravity : MonoBehaviour
{
	private Text text;

	void Start()
	{
		text = this.GetComponent<Text>();
	}

	// Update is called once per frame
	void Update()
	{
		string debugStr = $"X: {Physics.gravity.x} \n Y: {Physics.gravity.y} \n Z: {Physics.gravity.z}";
		text.text = debugStr;
	}
}