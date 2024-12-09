// Found in video 2 of 2023 Unity VR basics
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Controls hand animations in VR by reading input from grip and trigger actions.
/// Requires an Animator component to animate the hand model.
/// </summary>
[RequireComponent(typeof(Animator))]
public class AnimateHandController : MonoBehaviour
{
    // References to Input Actions for grip and trigger
    public InputActionReference gripInputActionReference;
    public InputActionReference triggerInputActionReference;

    // Animator component to control the hand animations
    private Animator _handAnimator;

    // Values for grip and trigger inputs
    private float _gripValue;
    private float _triggerValue;

    /// <summary>
    /// Called once when the script is initialized.
    /// Sets up the

