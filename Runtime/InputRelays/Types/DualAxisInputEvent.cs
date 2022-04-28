using FM.Runtime.Systems.Events;
using UnityEngine;

namespace FM.Runtime.Systems.Input
{
    [CreateAssetMenu(menuName ="Input/Dual Axis Input Event")]
    public class DualAxisInputEvent : ValueInputRelay<Vector2Event, Vector2> { }
}