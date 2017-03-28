namespace Moz {
	public class Variable<T>: Publisher<T> where T: new() {
		private T _value;

    public Variable() {
      this._value = default(T);

      if(this._value == null) {
        this._value = new T();
      }
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