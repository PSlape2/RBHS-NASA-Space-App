using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Planets {
    public abstract class PredefinedPlanet : Planet {
        
        protected PredefinedPlanet(float temperature, float oxygen, float distFromStar, float dayLength, float yearLength, float mass, float gravity, float radius, float gravField, float humidity, string soilComp, string geography, string challenges, string solutions, string color, string type) 
            : base(temperature, oxygen, distFromStar, dayLength, yearLength, mass, gravity, radius, gravField, humidity, soilComp, geography, challenges, solutions, color, type) {}

        public override GameObject render() {
            return Instantiate(
                planetPrefab,
                new Vector3(0,0,0),
                Quaternion.identity
            );
        }
    }
}