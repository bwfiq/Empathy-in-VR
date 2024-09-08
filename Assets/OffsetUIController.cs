using UnityEngine;
using UnityEngine.UI;
using TMPro; // Import TextMeshPro namespace

/// <summary>
/// Controls the user interface for adjusting offsets of the VR IK rig.
/// </summary>
public class OffsetUIController : MonoBehaviour
{
	[SerializeField] private IKTargetFollowVRRig ikTargetFollowVRRig;
	[SerializeField] private Slider slider;
	[SerializeField] private TMP_Text valueLabel;

	private void Start()
	{
		// Initialize sliders with current values
		slider.value = ikTargetFollowVRRig.head.trackingPositionOffset.z;        
		valueLabel.text = $"Head Z Offset: {slider.value:F2}";

		// Add listener to update Y offset and label when the slider value changes
		slider.onValueChanged.AddListener(_ => UpdateOffset());
	}
	private void UpdateOffset()
	{
		ikTargetFollowVRRig.head.trackingPositionOffset.z = slider.value;
		valueLabel.text = $"Head Z Offset: {slider.value:F2}"; // Example format with 2 decimal places
	}
}