
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class AppearGhostZone : UdonSharpBehaviour
{
    public GameObject ghost;




    public override void OnPlayerTriggerEnter(VRCPlayerApi player)
    {
        base.OnPlayerTriggerEnter(player);

        ghost.SetActive(true);
    }

    public override void OnPlayerTriggerExit(VRCPlayerApi player)
    {
        base.OnPlayerTriggerExit(player);

        ghost.SetActive(false);
    }

    public override void OnPlayerTriggerStay(VRCPlayerApi player)
    {
        base.OnPlayerTriggerStay(player);
    }
}
