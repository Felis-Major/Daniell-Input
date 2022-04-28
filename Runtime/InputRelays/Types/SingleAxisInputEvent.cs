using FM.Runtime.Systems.Events;
using UnityEngine;

namespace FM.Runtime.Systems.Input
{
    [CreateAssetMenu(menuName = "Input/Single Axis Input Event")]
    public class SingleAxisInputEvent : ValueInputRelay<FloatEvent, float> { }
}