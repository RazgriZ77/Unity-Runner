using UnityEngine;

namespace HarryB97.Tools.Runner.Example {
    public class ExampleEntity : MonoBehaviour {
        // ==================== VARIABLES ===================
        #region Private Variables
        [SerializeField] private float delay = 3f;
        private ExampleClass exampleClass;
        #endregion
        
        // ==================== START ====================
        private void Start() {
            exampleClass = new ExampleClass(delay);
        }
    }
}