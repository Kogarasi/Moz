using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Moz {
	public class SingletonBehaviour<T> : MonoBehaviour where T : SingletonBehaviour<T> {

		static private SingletonBehaviour<T> _instance;

		void Awake(){
			if(_instance != null){
				Debug.LogError("Duplicated Singleton Ojbect: " + typeof(T).FullName );
			} else {
				_instance = this;
			}
		}

		void OnDestroy(){
			_instance = null;
		}

		public T instance {
			get {
				return _instance as T;
			}
		}
	}
}