using System;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

namespace Test1.Script
{
    public class BasicManager : MonoBehaviour
    {

        [SerializeField] private Button clientButton;
        
        
        private void Start()
        {
            clientButton.onClick.AddListener(() => NetworkManager.Singleton.StartClient());
        }
    }
}
