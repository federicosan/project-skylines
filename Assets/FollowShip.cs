﻿/* Copyright (C) Luaek - All Rights Reserved
 * Unauthorized copying of this file, via any medium is strictly prohibited
 * Proprietary and confidential
 * Written by Maxi Levi <maxilevi@live.com>, November 2017
 */

using UnityEngine;
using System.Collections;

public class FollowShip : MonoBehaviour {

	public GameObject TargetShip;
	public Vector3 Offset;

	void Update () {
		if (TargetShip == null)
			return;
		this.transform.position = Lerp (this.transform.position, TargetShip.transform.position + TargetShip.transform.forward * Offset.z + TargetShip.transform.up * Offset.y, Time.deltaTime * 8f);
		this.transform.LookAt(TargetShip.transform.position, Vector3.up);
        //this.transform.rotation = Quaternion.Slerp(this.transform.rotation, TargetShip.transform.rotation, Time.deltaTime * 32f);
    }

	public Vector3 Lerp(Vector3 A, Vector3 B, float C){
		return new Vector3 (Mathf.Lerp(A.x, B.x, C), Mathf.Lerp(A.y, B.y, C), Mathf.Lerp(A.z, B.z, C)  );
	}
}
