using System;
using UnityEngine;
using System.Collections;

public class TimeManager : MonoBehaviour {

	public void ManipulateTime(float newTime, float duration){

		if (Math.Abs(Time.timeScale) < 0.0001f)
			Time.timeScale = 0.1f;

		StartCoroutine (FadeTo (newTime, duration));
	}

	IEnumerator FadeTo(float value, float time){

		for (float t = 0f; t < 1; t += Time.deltaTime / time) {

			Time.timeScale = Mathf.Lerp(Time.timeScale, value, t);

			if(Mathf.Abs(value - Time.timeScale) < .01f){
				Time.timeScale = value;
				yield return null;
			}

			yield return null;
		}

	}

}
