using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Moz {
	public class Variable<T>: Publisher<T> where T: new() {
		private T _value;

		public Variable(T _value){
			this._value = _value;
		}

		public T value {
			get { return _value; }
			set {
				_value = value;
				publish(value);
			}
		}
	}
}