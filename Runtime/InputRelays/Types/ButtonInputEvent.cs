using FM.Runtime.Core;
using FM.Runtime.Systems.Events;
using UnityEngine;

namespace FM.Runtime.Systems.Input
{
    [CreateAssetMenu(menuName = PackageConstants.BasePath + "/Input/" + nameof(ButtonInputEvent), fileName = "New " + nameof(ButtonInputEvent))]
    public class ButtonInputEvent : VoidInputRelay<VoidEvent> { }
}