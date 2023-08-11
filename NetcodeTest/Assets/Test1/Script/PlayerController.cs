using System;
using Unity.Netcode;
using UnityEngine;

namespace Test1.Script
{

    public class PlayerController : NetworkBehaviour
    {
        private CharacterController _characterController;

        public override void OnNetworkSpawn()
        {
     //       base.OnNetworkSpawn();
      //      if(!IsOwner) Destroy(this);
        }

        private void Start()
        {
            _characterController = GetComponent<CharacterController>();
        }

        
        

        private void Update()
        {

           // if (!IsOwner) return;


            Camera.main.transform.position = transform.position + new Vector3(0, 10, 0);
            Camera.main.transform.LookAt(transform);
            
                var x = Input.GetAxis("Horizontal")*5;
            var z = Input.GetAxis("Vertical")*5;

            _characterController.SimpleMove( new Vector3( x, -9.8f, z));
        }
    }
}
