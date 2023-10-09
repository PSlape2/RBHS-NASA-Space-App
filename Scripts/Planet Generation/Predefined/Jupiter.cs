using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Planets {
    public class Jupiter : PredefinedPlanet {

        public Jupiter() : base(
                13.9f,
                0.21f,
                1f,
                24f,
                365f,
                5.97f,
                9.81f,
                6378f,
                0,
                0.40f,
                "Various",
                "Mountains, valleys, and more",
                "no data",
                "no data",
                "blue and green",
                "rocky"
            ) {}

        public void OnEnable() {
            planetPrefab = Resources.Load("Prefabs/Solar System/Jupiter") as GameObject;
            this.render();
        }
    }
}

/*
            The Order

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