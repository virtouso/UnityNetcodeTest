using Unity.Netcode.Components;
using UnityEngine;

namespace Test1.Script
{
    public class ClientNetworkTransform : NetworkTransform
    {
        protected override bool OnIsServerAuthoritative()
        {
            return false;
        }
    }
}
