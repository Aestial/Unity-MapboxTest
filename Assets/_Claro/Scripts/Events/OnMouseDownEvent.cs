﻿namespace Claro.Map
{
    using UnityEngine;
    using UnityEngine.Events;

    public class OnMouseDownEvent : MonoBehaviour
    {
        public UnityEvent onMouseDownEvent;
        private new bool enabled = false;

        void OnMouseDown()
        {
            Debug.Log("Click Events Invoked!");
            this.onMouseDownEvent.Invoke();
        }
    }
}