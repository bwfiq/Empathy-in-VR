using UnityEngine;
using UnityEngine.UI;
using TMPro; // Import TextMeshPro namespace

/// <summary>
/// Controls the user interface for adjusting offsets of the VR IK rig.
/// </summary>
public class OffsetUIController : MonoBehaviour
{
	[SerializeField]
	private IKTargetFollowVRRig ikTargetFollowVRRig;

	// UI Elements for body position adjustments
	[Header("UI Slider for Body Y Position Offset")]
	[SerializeField] private Slider slider;

	// Reference to the TextMeshPro label for displaying the slider value
	[Header("TextMeshPro Label")]
	[SerializeField] private TMP_Text valueLabel;

	private void Start()
	{
		// Initialize sliders with current values
		slider.value = ikTargetFollowVRRig.headBodyPositionOffset.z;        
		valueLabel.text = $"Body Z Offset: {slider.value:F2}";

		// Add listener to update Y offset and label when the slider value changes
		slider.onValueChanged.AddListener(_ => UpdateOffset());
	}
	private void UpdateOffset()
	{
		ikTargetFollowVRRig.headBodyPositionOffset.z = slider.value;
		valueLabel.text = $"Body Z Offset: {slider.value:F2}"; // Example format with 2 decimal places
	}
}