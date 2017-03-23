using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Moz {
	public class Publisher<T> {
		private List<Subscriber<T>> subscriberList = new List<Subscriber<T>>();

		public void publish(T item){
			foreach( var elem in subscriberList ){
				elem.onMessage(item);
			}
		}
		
		public Subscriber<T> subscribe(){
			var subscriber = new Subscriber<T>();
			this.subscriberList.Add(subscriber);

			return subscriber;
		}

		public Subscriber<T> subscribe(Action<T> callback){
			var subscriber = subscribe();
			subscriber.setCallback(callback);

			return subscriber;			
		}

		public void unsubscribe(Subscriber<T> subscriber){
			this.subscriberList.Remove(subscriber);
		}
	}
}