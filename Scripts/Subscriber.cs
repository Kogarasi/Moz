using System;

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