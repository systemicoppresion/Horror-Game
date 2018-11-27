using UnityEngine;
using System.Collections;

public class Light { 
	public class life
		{
		float power = 100.0f;
		}
	private class wtfeven
		{
		float maxPower = 100.0f;
		}
	private class scoobert
		{
		float minPower = 0.0f;
		}
	public class doobert
		{
	float batteryCharge = 100.0f;
	}
	public class butwhytho
	{
	int batteryCount = 3;
	}
	public class thatguy
		{
	float powerDrain = 1.0f;
		}
	private class boi
		{
		bool usable = true;
		}

void Start ()
{
}
void Update () 
{
	//If the F key is pressed and the power is greater than zero, then the flashlight will toggle between on and off
	if (Input.GetKeyDown (KeyCode.F) && usable) 
	{
		flashlight.enabled = !flashlight.enabled;
	}
	//While the flashlight is off, the power will drain
	if (flashlight.enabled) 
	{
		power -= Time.deltaTime * powerDrain;
	}
	//This is to ensure that the power will never go over 100
	if (power > maxPower) 
	{
		power = maxPower;
	}
	//This is to disable to flashlight and make sure it can't be used until the player uses a battery to recharge the flashlight
	if (power < minPower) 
	{
		power = minPower;
		flashlight.enabled = false;
		usable = false;
	}
	//After you replace the batteries, it allows you to use the flashlight again
	if (power > minPower)
	{
		usable = true;
	}
	//This says that if the player has at least one battery, and if they press R, then the flashlight will be fully charged
	if (Input.GetKeyDown (KeyCode.R) && batteryCount > 0)
	{
		power += batteryCharge;
		batteryCount -= 1;
	}
}
}