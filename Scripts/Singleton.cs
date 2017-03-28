namespace Moz {
	public class Singleton<T> where T: class, new() {
		static private T _instance;

		public static T instance {
			get {
				if(_instance == null ){
					_instance = new T();
				}
				return _instance;
			}
		}
	}
}