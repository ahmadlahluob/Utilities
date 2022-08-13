using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RiseOfArabs.DevTools.Utilities.GameObjectExtensions

{
    public static class Component_Xs 
    {
        public static bool TryGetComponentInChildren<T>(this Component _this, out T _component)
            where T : Object
        {
            _component = _this.GetComponentInChildren<T>();
            return _component != null;
        }
        public static bool TryGetComponentInChildren<T>(this Component _this)
            where T : Object
        {
            
            return _this.GetComponentInChildren<T>() != null;
        }
        public static bool TryGetComponentInChildren<T>(this Component _this, out T _component,bool _includeInactive)
            where T : Component
        {
            _component = _this.GetComponentInChildren<T>(_includeInactive);
            return _component != null;
        }
        public static bool TryGetComponentInChildren<T>(this Component _this,bool _includeInactive)
            where T : Component
        {
            
            return _this.GetComponentInChildren<T>(_includeInactive) != null;
        }
        public static bool TryGetComponentsInChildren<T>(this Component _this, out T[] _components)
            where T : Component
        {
            _components = _this.GetComponentsInChildren<T>();
            return _components != null;
        } 
        public static bool TryGetComponentsInChildren<T>(this Component _this)
            where T : Component
        {
           
            return _this.GetComponentsInChildren<T>() != null;
        }
        public static bool TryGetComponentsInChildren<T>(this Component _this,bool _includeInactive)
            where T : Component
        {
           
            return _this.GetComponentsInChildren<T>(_includeInactive) != null;
        }
        public static bool TryGetComponentsInChildren<T>(this Component _this, out T[] _components,bool _includeInactive)
            where T : Component
        {
            _components = _this.GetComponentsInChildren<T>(_includeInactive);
            return _components != null;
        }
        public static bool TryGetComponentInParent<T>(this Component _this, out T _component)
            where T : Component
        {
            _component = _this.GetComponentInParent<T>();
            return _component != null;
        }
        public static bool TryGetComponentInParent<T>(this Component _this)
            where T : Component
        {
            
            return _this.GetComponentInParent<T>() != null;
        }
        public static bool TryGetComponentInParent<T>(this Component _this,bool _includeInactive)
            where T : Component
        {
            
            return _this.GetComponentInParent<T>(_includeInactive) != null;
        }
        public static bool TryGetComponentInParent<T>(this Component _this, out T _component , bool _includeInactive)
            where T : Component
        {
            _component = _this.GetComponentInParent<T>(_includeInactive);
            return _component != null;
        }
        public static bool TryGetComponentsInParent<T>(this Component _this, out T[] _components)
            where T : Component
        {
            _components = _this.GetComponentsInParent<T>();
            return _components != null;
        }
        public static bool TryGetComponentsInParent<T>(this Component _this)
            where T : Component
        {
            
            return _this.GetComponentsInParent<T>() != null;
        }
        public static bool TryGetComponentsInParent<T>(this Component _this,bool _includeInactive)
            where T : Component
        {
            
            return _this.GetComponentsInParent<T>(_includeInactive) != null;
        }
        public static bool TryGetComponentsInParent<T>(this Component _this, out T[] _components,bool _includeInactive)
            where T : Component
        {
            _components = _this.GetComponentsInParent<T>(_includeInactive);
            return _components != null;
        }
        public static bool TryFindObjectOfType<T>(this Component _this, out T _object)
            where T : Object
        {
            _object = Object.FindObjectOfType<T>();
            return _object != null;
        }
        public static bool TryFindObjectOfType<T>(this Component _this)
            where T : Object
        {
            return Object.FindObjectOfType<T>() != null;
        }
        public static bool TryFindObjectOfType<T>(this Component _this,bool _includeInactive)
            where T : Object
        {
            return Object.FindObjectOfType<T>(_includeInactive) != null;
        }
        public static bool TryFindObjectOfType<T>(this Component _this, out T _object,bool _includeInactive)
            where T : Object
        {
            _object = Object.FindObjectOfType<T>(_includeInactive);
            return _object != null;
        }
       public static bool TryFindObjectsOfType<T>(this Component _this, out T[] _objects)
            where T : Object
        {
            _objects = Object.FindObjectsOfType<T>();
            return _objects != null;
        }
        public static bool TryFindObjectsOfType<T>(this Component _this)
            where T : Object
        {
            
            return Object.FindObjectsOfType<T>() != null;
        }
        public static bool TryFindObjectsOfType<T>(this Component _this,bool _includeInactive)
            where T : Object
        {
            
            return Object.FindObjectsOfType<T>(_includeInactive) != null;
        }
        public static bool TryFindObjectsOfType<T>(this Component _this, out T[] _objects, bool _includeInactive)
            where T : Object
        {
            _objects = Object.FindObjectsOfType<T>(_includeInactive);
            return _objects != null;

        }
    }
  
}