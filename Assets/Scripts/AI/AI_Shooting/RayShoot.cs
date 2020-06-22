using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class RayShoot : MonoBehaviour
{
	public Transform firePoint;
	public Transform rocket;
	public LineRenderer lineRendererAim;
	public LineRenderer lineRendererShoot;
	public float timer;
	public float time;
	private bool inTrigger = false;
	private bool timerOn = false;
	public GameObject targetLocation;

	public int damage = 1;

	void Start()
	{
		time = timer;
	}
	void Update()
	{
		Debug.Log("The distance is " + (rocket.transform.position - transform.position).magnitude);
		float distance = (rocket.transform.position - transform.position).magnitude;
		// RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, (rocket.transform.position - firePoint.position));

		Debug.DrawRay(start: firePoint.position, dir: (rocket.transform.position - firePoint.position), color: Color.yellow);
		if (timerOn == false)
		{
			Debug.Log("The timet is on " + timer);
			timer -= Time.deltaTime;
		}

		// if(inTrigger == true)
		if (distance <= 25f)
		{
			if (timer <= 0f)
			{
				StartCoroutine(Shoot());
				timer = time;
			}
		}
	}

	IEnumerator Shoot ()
	{
		Ray2D ray = new Ray2D(firePoint.position,targetLocation.transform.position);
		RaycastHit2D enemyPew;

		if(Physics2D.Raycast2D(ray,out enemyPew))
		{

		}

		timerOn = false;

		Debug.Log("1");

		GameObject clone;
		clone = Instantiate(targetLocation, new Vector2(rocket.transform.position.x, rocket.transform.position.y), transform.rotation);

		Debug.Log(targetLocation.transform.position);

		lineRendererAim.SetPosition(0, firePoint.transform.position);
		lineRendererAim.SetPosition(1, clone.transform.position);

		lineRendererAim.enabled = true;

		this.gameObject.GetComponent<AIPath>().enabled = false;

		yield return new WaitForSeconds(4f);

		Debug.Log("2");

		lineRendererAim.enabled = false;

		lineRendererShoot.SetPosition(0, firePoint.position);
		lineRendererShoot.SetPosition(1, clone.transform.position * 2);

		lineRendererShoot.enabled = true;

		yield return new WaitForSeconds(4f);

		Debug.Log("3");

		Destroy(targetLocation);

		lineRendererShoot.enabled = false;

		this.gameObject.GetComponent<AIPath>().enabled = true;

		timerOn = true;
	}
}