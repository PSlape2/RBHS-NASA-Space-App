using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Planets {
    public class Neptune : PredefinedPlanet {

        public Neptune() : base(
                13.9f, // temperature
                0.21f, // oxygen
                1f, // distance from star
                24f, // day length
                365f, // year length
                5.97f, // mass
                9.81f, // gravity
                6378f, // radius
                0, // gravField
                0.40f, // humidity
                "Various", // soil composition
                "Mountains, valleys, and more", // geography
                "no data", // challenges
                "no data", // solutions
                "blue and green", // color
                "rocky" // type
            ) {}

        public void OnEnable() {
            planetPrefab = Resources.Load("Prefabs/Solar System/Neptune") as GameObject;
            this.render();
        }
    }
}

/*
            this.temperature = temperature;
            this.oxygen = oxygen;
            this.distFromStar = distFromStar;
            this.dayLength = dayLength;
            this.yearLength = yearLength;
            this.mass = mass;
            this.gravity = gravity;
            this.radius = radius;
            this.gravField = gravField;
            this.humidity = humidity;
            this.soilComp = soilComp;
            this.geography = geography;
            this.challenges = challenges;
            this.solutions = solutions;
            this.color = color;
            this.type = type;

*/