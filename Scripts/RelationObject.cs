using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Moz {
  public class RelationObject<T> where T : MonoBehaviour {
    private static T _instance;
    public T instance {
      get {
        if(_instance == null) {
          var type = typeof(T);
          var go = GameObject.Find(type.Name);
          _instance = go.GetComponent<T>();
        }

        return _instance;
      }
    }

    public void apply(T view) {
      _instance = view;
    }
  }
}