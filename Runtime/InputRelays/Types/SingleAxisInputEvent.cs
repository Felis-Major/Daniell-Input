using FM.Runtime.Core;
using FM.Runtime.Systems.Events;
using UnityEngine;

namespace FM.Runtime.Systems.Input
{
	[CreateAssetMenu(menuName = PackageConstants.BasePath + "/Input/" + nameof(SingleAxisInputEvent), fileName = "New " + nameof(SingleAxisInputEvent))]
	public class SingleAxisInputEvent : ValueInputRelay<FloatEvent, float> { }
}