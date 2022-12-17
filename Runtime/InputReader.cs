using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace FM.Runtime.Input
{
	[Serializable]
	public class BaseInputAction<T> where T : UnityEventBase
	{
		[Header("Input Settings")]
		[SerializeField]
		protected InputAction _inputAction;

		[Header("Events")]
		public T pressed;
		public T held;
		public T released;
	}

	[Serializable]
	public class ButtonInputAction : BaseInputAction<UnityEvent>
	{

	}

	[Serializable]
	public class DualAxisInputAction : BaseInputAction<UnityEvent<Vector2>>
	{

	}

	[Serializable]
	public class SingleAxisInputAction : BaseInputAction<UnityEvent<float>>
	{

	}

	public class InputReader : MonoBehaviour
	{
		public bool IsHeld { get; private set; }

		public DualAxisInputAction _dualAxisInput;
		public ButtonInputAction _bt;
		public SingleAxisInputAction _axis;

		private void Awake()
		{
			print(typeof(UnityEvent).AssemblyQualifiedName);
		}
		//private void OnEnable()
		//{
		//	_inputAction.Enable();
		//	Reset();
		//}

		//private void OnDisable()
		//{
		//	_inputAction.Disable();
		//	Reset();
		//}

		//private void Update()
		//{
		//	bool actionWasPressed = _inputAction.inProgress && !IsHeld;
		//	bool actionWasReleased = !_inputAction.inProgress && IsHeld;



		//	Debug.Log(_inputAction.ReadValue<Vector2>());

		//	if (actionWasPressed)
		//	{
		//		IsHeld = true;
		//		//Debug.Log("Pressed");
		//	}
		//	else if (actionWasReleased)
		//	{
		//		IsHeld = false;
		//		//Debug.Log("Released");
		//	}
		//	else if (IsHeld)
		//	{
		//		//Debug.Log("Held");
		//	}
		//}

		//private void Reset()
		//{
		//	IsHeld = false;
		//}
	}
}