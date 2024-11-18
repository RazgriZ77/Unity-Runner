using System;
using UnityEngine;

namespace HarryB97.Tools.Runner.Example {
    [Serializable]
    public class ExampleClass : IRunnable {
        // ==================== VARIABLES ===================
        #region Private Variables
        private float timeStamp;
        #endregion
        
        // ==================== START ====================
        public ExampleClass(float _delay) {
            timeStamp = Time.time + _delay;

            // Añadimos un "Update" dentro de la clase
            Runner.Get.AddTicks(this);
        }

        void IRunnable.Ticks() {
            if (Time.time < timeStamp) Debug.Log("Inside Loop!");
            else {
                // Eliminamos el "Update" de la clase
                Runner.Get.RemoveTicks(this);
                Debug.Log("Removed from Loop!");
            }
        }
    }
}