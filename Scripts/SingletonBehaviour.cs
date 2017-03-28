using UnityEngine;

namespace Moz {
	public class SingletonBehaviour<T> : MonoBehaviour where T : SingletonBehaviour<T> {

		static private T _instance;

		void Awake(){
			if(_instance != null){
				Debug.LogError("Duplicated Singleton Ojbect: " + typeof(T).FullName );
			} else {
				_instance = GetComponent<T>();
			}
		}

		void OnDestroy(){
			_instance = null;
		}

		public static T instance {
			get {
				return _instance as T;
			}
		}
	}
}