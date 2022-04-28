using FM.Runtime.Systems.Events;
using UnityEngine;

namespace FM.Runtime.Systems.Input
{
    [CreateAssetMenu(menuName = "Input/Button Input Event")]
    public class ButtonInputEvent : VoidInputRelay<VoidEvent> { }
}