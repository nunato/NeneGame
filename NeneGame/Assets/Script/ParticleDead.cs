﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDead : MonoBehaviour 
{
	private float lifeTime = 1f;

	void Start () {
		Destroy( gameObject, lifeTime );
	}
	
}
