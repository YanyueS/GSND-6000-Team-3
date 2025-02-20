using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace EmzyController
{
    [CreateAssetMenu]

    [SerializeField]
    public class PlayerSettings : ScriptableObject
    {

        #region Stats
        [Header("Horizontal")]
        [SerializeField] private float maxSpeed = 10;
        [SerializeField] private float acceleration = 100;
        [SerializeField] private float groundDeceleration = 60;
        [SerializeField] private float airAcceleration = 30;
        [SerializeField] private float airDeceleration = 30;
        [SerializeField] private float snapDistance = 0.1f;
        [SerializeField] private float groundingDistance = 0.1f;
        [Header("JUMP")]
        [Tooltip("Amount of air jumps allowed. e.g. 1 is a standard double jump"), Min(0)]
        [SerializeField] private int maxAirJumps = 1;
        [Tooltip("strength of MidAir jump compared to grounded jump")]
        [SerializeField] private float midAirJumpStrength = 1f;
        [Tooltip("The immediate velocity applied when jumping")]
        [SerializeField] private float jumpHeight = 4;
        [Tooltip("The maximum vertical movement speed")]
        [SerializeField] private float maxFallSpeed = 40;
        [Tooltip("The player's capacity to gain fall speed. a.k.a. In Air Gravity")]
        [SerializeField] private float fallAcceleration = -110;
        [Tooltip("The gravity while the player is holding jump")]
        [SerializeField] private float risingFallAcceleration = -70;
        [Tooltip("The percent vertical speed is multiplied by when jump is letgo")]
        [Range(0, 1)]
        [SerializeField] private float jumpCutSpeed = 0.3f;
        [Tooltip("The fixed frames before coyote jump becomes unusable. Coyote jump allows jump to execute even after leaving a ledge")]
        [Min(0)]
        [SerializeField] private float coyoteTime = 0.5f;
        [Tooltip("The amount of fixed frames we buffer a jump. This allows jump input before actually hitting the ground")]
        [Min(0)]
        [SerializeField] private float jumpBufferWindow = 0.5f;

        [Header("General")]
        // [SerializeField] private PlayerState startState = PlayerState.normal;
        [SerializeField] private LayerMask climbLayer;

        [SerializeField] private float neutralJumpThreshold = 0.2f;
        [SerializeField] private float jumpTransitionTime = 0.1f;
        [Min(0)]
        [SerializeField]
        private float tiltSmoothTime = 0.1f;

        public float MaxSpeed => maxSpeed;
        public float Acceleration => acceleration;
        public float GroundDeceleration => groundDeceleration;
        public float AirAcceleration => airAcceleration;
        public float AirDeceleration => airDeceleration;
        public float SnapDistance => snapDistance;
        [Tooltip("Amount of air jumps allowed. e.g. 1 is a standard double jump")]
        public int MaxAirJumps => maxAirJumps;
        [Tooltip("strength of MidAir jump compared to grounded jump")]
        public float MidAirJumpStrength => midAirJumpStrength;
        [Tooltip("The immediate velocity applied when jumping")]
        public float JumpHeight => jumpHeight;
        [Tooltip("The maximum vertical movement speed")]
        public float MaxFallSpeed => maxFallSpeed;
        [Tooltip("The player's capacity to gain fall speed. a.k.a. In Air Gravity")]
        public float FallAcceleration => fallAcceleration;
        [Tooltip("The gravity while the player is holding jump")]
        public float RisingFallAcceleration => risingFallAcceleration;
        [Tooltip("The percent vertical speed is multiplied by when jump is let go")]
        public float JumpCutSpeed => jumpCutSpeed;
        [Tooltip("The fixed frames before coyote jump becomes unusable. Coyote jump allows jump to execute even after leaving a ledge")]
        public float CoyoteTime => coyoteTime;
        [Tooltip("The amount of fixed frames we buffer a jump. This allows jump input before actually hitting the ground")]

        public float JumpBufferWindow => jumpBufferWindow;
        public float NeutralJumpThreshold => neutralJumpThreshold;
        public float TiltSmoothTime => tiltSmoothTime;
        public LayerMask ClimbLayer => climbLayer;
        public float GroundingDistance => groundingDistance;
        public float JumpTransitionTime => jumpTransitionTime;
        #endregion
        #region Conditions
        private bool noAirJumps()
        {
            return MaxAirJumps <= 0;
        }
        #endregion
    }
}