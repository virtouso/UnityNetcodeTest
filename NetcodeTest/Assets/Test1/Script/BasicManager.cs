
using Unity.Netcode;
using Unity.Netcode.Transports.UTP;
using UnityEngine;
using UnityEngine.UI;

namespace Test1.Script
{
    public class BasicManager : MonoBehaviour
    {

        [SerializeField] private Button clientButton;
        [SerializeField] private UnityTransport transport;
        [SerializeField] private bool debug;
        private void Start()
        {
            clientButton.onClick.AddListener(() => NetworkManager.Singleton.StartClient());

            if (debug)
            {
                transport.SetDebugSimulatorParameters(packetDelay:120, packetJitter:5, dropRate:3);
            }
            
            
            
        }
    }
}
