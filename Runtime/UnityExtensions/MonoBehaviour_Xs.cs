using UnityEngine;

namespace RiseOfArabs.DevTools.Utilities.GameObjectExtensions
{
    public static class MonoBehaviour_Xs
    {
        #region Get in children
        public static bool TryGetComponentInChildren<T>(this MonoBehaviour _this, out T _component)
            where T : MonoBehaviour => (_component = _this.GetComponentInChildren<T>()) != null;
        public static bool TryGetComponentInChildren<T>(this MonoBehaviour _this, out T _component, bool _includeInactive)
            where T : MonoBehaviour => (_component = _this.GetComponentInChildren<T>( _includeInactive )) != null;

        public static bool TryGetComponentsInChildren<T>(this MonoBehaviour _this, out T[] _components)
            where T : MonoBehaviour => (_components = _this.GetComponentsInChildren<T>()) != null;
        public static bool TryGetComponentsInChildren<T>(this MonoBehaviour _this, out T[] _components, bool _includeInactive)
            where T : MonoBehaviour => (_components = _this.GetComponentsInChildren<T>( _includeInactive )) != null;
        #endregion

        #region Get in parent
        public static bool TryGetComponentInParent<T>(this MonoBehaviour _this, out T _component)
            where T : MonoBehaviour
        => (_component = _this.GetComponentInParent<T>()) != null;
#if UNITY_2020 || UNITY_2021
        public static bool TryGetComponentInParent<T>(this MonoBehaviour _this, out T _component, bool _includeInactive)
            where T : MonoBehaviour => (_component = _this.GetComponentInParent<T>( _includeInactive )) != null;
#endif

        public static bool TryGetComponentsInParent<T>(this MonoBehaviour _this, out T[] _components)
            where T : MonoBehaviour
        => (_components = _this.GetComponentsInParent<T>()) != null;
        public static bool TryGetComponentsInParent<T>(this MonoBehaviour _this, out T[] _components, bool _includeInactive)
            where T : MonoBehaviour
        => (_components = _this.GetComponentsInParent<T>( _includeInactive )) != null;
        #endregion

        #region Find object of type
        public static bool TryFindObjectOfType<T>(this MonoBehaviour _this, out T _object)
            where T : MonoBehaviour => (_object = Object.FindObjectOfType<T>()) != null;
#if UNITY_2020 || UNITY_2021
        public static bool TryFindObjectOfType<T>(this MonoBehaviour _this, out T _object, bool _includeInactive)
            where T : MonoBehaviour => (_object = Object.FindObjectOfType<T>( _includeInactive )) != null;
#endif

        public static bool TryFindObjectsOfType<T>(this MonoBehaviour _this, out T[] _objects)
             where T : MonoBehaviour => (_objects = Object.FindObjectsOfType<T>()) != null;
#if UNITY_2020 || UNITY_2021
        public static bool TryFindObjectsOfType<T>(this MonoBehaviour _this, out T[] _objects, bool _includeInactive)
            where T : MonoBehaviour => (_objects = Object.FindObjectsOfType<T>( _includeInactive )) != null;
#endif
        #endregion
    }
}