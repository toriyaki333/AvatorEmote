using RootMotion.FinalIK;

using UnityEngine;

#pragma warning disable 649

namespace SteamVR_Sandbox.Scripts
{
    public class AvatarCalibrator : MonoBehaviour
    {
        private const float PlayerHandDistanceByHeight = .78f;

        // Start is called before the first frame update
        private void Start()
        {
            if (World == null)
                return;

            var avatarHandDistance = Vector3.Distance(IK.references.leftHand.position, IK.references.rightHand.position);
            var playerHandDistance = PlayerHeight * PlayerHandDistanceByHeight;
            var worldScale = playerHandDistance / avatarHandDistance;

            World.transform.localScale = Vector3.one * worldScale;
        }

        [SerializeField]
        private GameObject World;

        [SerializeField]
        private VRIK IK;

        [SerializeField]
        [Tooltip("Player Real Height (m)")]
        private float PlayerHeight;
    }
}