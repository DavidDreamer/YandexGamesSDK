﻿using System;
using UnityEngine;

namespace Dreambox
{
	[Serializable]
	public struct FloatRange
	{
		[field: SerializeField]
		public float Min { get; set; }

		[field: SerializeField]
		public float Max { get; set; }

		public float Clamp(float value) => Mathf.Clamp(value, Min, Max);

		public float Evaluate(float value) => Mathf.Lerp(Min, Max, value);
	}
}
