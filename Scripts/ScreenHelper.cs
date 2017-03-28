using UnityEngine;

namespace NS.Helper {
  public static class ScreenHelper {

    public static float width(Transform transform) {
      var canvas = transform.root.GetComponent<Canvas>();
      var rect = canvas.GetComponent<RectTransform>();

      return rect.sizeDelta.x;
    }

    public static float height(Transform transform) {
      var cavas = transform.root.GetComponent<Canvas>();
      var rect = cavas.GetComponent<RectTransform>();

      return rect.sizeDelta.y;
    }

  }
}