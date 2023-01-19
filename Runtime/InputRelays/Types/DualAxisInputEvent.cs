using FM.Runtime.Core;
using FM.Runtime.Systems.Events;
using UnityEngine;

namespace FM.Runtime.Systems.Input
{
	[CreateAssetMenu(menuName = PackageConstants.BasePath + "/Input/" + nameof(DualAxisInputEvent), fileName = "New " + nameof(DualAxisInputEvent))]
	public class DualAxisInputEvent : ValueInputRelay<Vector2Event, Vector2> { }
}