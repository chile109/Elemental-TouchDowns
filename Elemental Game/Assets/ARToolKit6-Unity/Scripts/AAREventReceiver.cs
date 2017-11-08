using UnityEngine;

/// <summary>
/// Any object that implements IAREventReceiver is eligable to register for tracking
/// events from any ARTrackable object.
/// To register with an ARTrackable:
///   arTrackedMarker.eventReceivers.add(this);
/// </summary>
/// 
public abstract class AAREventReceiver : MonoBehaviour {
	public abstract void OnMarkerFound(ARTrackable marker);
	public abstract void OnMarkerTracked(ARTrackable marker);
	public abstract void OnMarkerLost(ARTrackable marker);
}
