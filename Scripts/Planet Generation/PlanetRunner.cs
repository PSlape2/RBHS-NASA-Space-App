using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Planets {
    public class PlanetRunner {
        Planet toGenerate;
        Material material;
        // var test;
        Mars mars;

        public PlanetRunner() {
            var test = (Earth) ScriptableObject.CreateInstance("Earth");
        }
        public PlanetRunner(string type) {
            
            if(type.Equals("Venus")) {
                var test = (Venus) ScriptableObject.CreateInstance(type);
            } else if(type.Equals("Mars")) {
                var test = (Mars) ScriptableObject.CreateInstance(type);
            } else if(type.Equals("Jupiter")) {
                var test = (Jupiter) ScriptableObject.CreateInstance(type);
            }  else if(type.Equals("Earth")) {
                var test = (Earth) ScriptableObject.CreateInstance(type);
            }  else if(type.Equals("Uranus")) {
                var test = (Uranus) ScriptableObject.CreateInstance(type);
            }  else if(type.Equals("Neptune")) {
                var test = (Neptune) ScriptableObject.CreateInstance(type);
            }  else if(type.Equals("Mars")) {
                var test = (Mars) ScriptableObject.CreateInstance(type);
            }  else if(type.Equals("Saturn")) {
                var test = (Saturn) ScriptableObject.CreateInstance(type);
            }  else if(type.Equals("Mercury")) {
                var test = (Mercury) ScriptableObject.CreateInstance(type);
            }
            
        }
        public PlanetRunner(string type, Material material) {
            this.material = material;

            var test = (Earth) ScriptableObject.CreateInstance(type);
        }

        // Update is called once per frame
        public void onUpdate() {
            // test.onUpdate();
        }
    }
}