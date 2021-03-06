﻿// Player\Control.cs

using UnityEngine;
using UnityEngine.Networking;

namespace Player {
    public class Control : NetworkBehaviour {
        public void Update ()
        {
            if (!isLocalPlayer) {
                return;
            }

            var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
            var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

            transform.Rotate(0, x, 0);
            transform.Translate(0, 0, z);
        }

        public override void OnStartLocalPlayer ()
        {
            FindObjectOfType<MeshRenderer>().GetComponent<MeshRenderer>().material.color = Color.blue;
        }
    }
}