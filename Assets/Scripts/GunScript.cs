using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class GunScript : MonoBehaviour, IInputClickHandler, IInputHandler
{

	public float damage = 10f;
	public float range = 100f;
	public float fireRate = 15f;

	public Camera fpsCam;
	public ParticleSystem muzzleFlash; 
	public GameObject impactEffect;

	private float nextTimeToFire = 0f;


    public void OnInputClicked(InputClickedEventData eventData)
    {         
        Shoot();

        
    }
    public void OnInputDown(InputEventData eventData)
    { }
    public void OnInputUp(InputEventData eventData)
    { }

	void Shoot () 
	{
        RaycastHit hit;

		if (Physics.Raycast (fpsCam.transform.position, fpsCam.transform.forward, out hit, range)) 
		{

			Debug.Log (hit.transform.name);

			ControllerZombie target = hit.transform.GetComponent<ControllerZombie> ();
			if (target != null) 
			{
				target.TakeDamage (damage);
			}

			GameObject impactGO = Instantiate (impactEffect, hit.point, Quaternion.LookRotation (hit.normal));
			Destroy(impactGO, 0.3f);
		}
	}
}
