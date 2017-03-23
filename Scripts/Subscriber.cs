using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Moz {
	public class Subscriber<T> {
		public Action<T> callback;

		public void setCallback(Action<T> callback){
			this.callback = callback;
		}

		public void onMessage(T item){
			this.callback(item);
		}
	}
}