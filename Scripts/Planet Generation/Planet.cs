using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Planets {
    public abstract class Planet : ScriptableObject {
        public const float TEMP_LOWER = -224f;
        public const float TEMP_UPPER =  427f;
        public const float OXYG_LOWER =  0f;
        public const float OXYG_UPPER =  21f;
        public const float DIST_LOWER =  0.39f;
        public const float DIST_UPPER =  30.1f;
        public const float GRAV_LOWER =  3.7f;
        public const float GRAV_UPPER =  24.79f;
        // public const float MASS_LOWER =  3.302f * Mathf.Pow(10,23); // kg
        // public const float MASS_UPPER =  1.8978f * Mathf.Pow(10,27); // kg
        public const float DAYLENGTH_LOWER =  2439f; // hr
        public const float DAYLENGTH_UPPER =  71492f; // hr
    
        protected float temperature, oxygen, distFromStar, dayLength, yearLength, mass, gravity, radius, gravField, humidity, waterContent;
        protected string soilComp, geography, challenges, solutions, color, type;

        protected Renderer mRenderer;
        protected GameObject planetPrefab;
        protected Texture main;
        protected Material material;

        public Planet(float temperature, float oxygen, float distFromStar, float dayLength, float yearLength, float mass, float gravity, float radius, float gravField, float humidity, string soilComp, string geography, string challenges, string solutions, string color, string type) {
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
        }
        /*
        public Planet() {
            
            temperature = Random.range(TEMP_LOWER, TEMP_UPPER);
            gravity = Random.range(GRAVITY_LOWER, GRAVITY_UPPER);
            oxygen = Random.range(OXYG_LOWER, OXYG_UPPER);
            distance = Random.range(DIST_LOWER, DIST_UPPER);
            mass = Random.range(MASS_LOWER, MASS_UPPER);
            radius = Random.range(RADI_LOWER, RADI_UPPER);
            daylength = Random.range(DAYLENGTH_LOWER, DAYLENGTH_UPPER);
            yearLength = Mathf.Pow(Mathf.pow(distance,3f) * 4f * Mathf.Pow(Mathf.PI, 2f) / (6.6743 * Mathf.pow(10f,-11f) * (/Mass of Star/ + mass)),1f/3f);
            soilComp = getSoilComposition();
            geography = getGeography();
            color = randomColor();
            climate = getClimate();
            magneticField = calculateMagField();
        }
        public float getGravity (float MASS, float RADIUS) {
            return 6.67430f * Mathf.Pow(10, -11) * MASS / (RADIUS * RADIUS);
        }
        */
        public virtual void onUpdate() {
            planetPrefab.transform.Rotate(new Vector3(Time.deltaTime, 0, 0));
        }
        public void setTexture(Texture main) {
            this.main = main;
        }
        public void setMaterial(Material mat) {
            material = mat;
        }
        protected void setMaterial() {
            mRenderer.material = material;
        }
        protected void setTexture() {
            mRenderer.material.SetTexture("_MainTex", main);
        }
        public virtual GameObject render() {
            setTexture();
            
            return Instantiate(
                planetPrefab,
                new Vector3(0, 0, 0),
                Quaternion.identity
            );
        }
        public string SoilComp   // SoilComp
        {
            get { return soilComp; }
            set { soilComp = value; }
        }
        public string Geography   // Geography
        {
            get { return geography; }
            set { geography = value; }
        }
        public string Challenges   // Challenges
        {
            get { return challenges; }
            set { 
                if(value == null || value == string.Empty) {
                    string valToSet = "";

                    // Write code here
                    
                    challenges = valToSet; 
                } else {
                    challenges = value;
                }
            }
        }
        public string Solutions   // Solutions
        {
            get { return solutions; }
            set { solutions = value; }
        }
        public float Temperature   // Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }
        public float Oxygen   // Oxygen
        {
            get { return oxygen; }
            set { oxygen = value; }
        }
        public float DistFromStar   // DistFromStar
        {
            get { return distFromStar; }
            set { distFromStar = value; }
        }
        public float DayLength   // DayLength
        {
            get { return dayLength; }
            set { dayLength = value; }
        }
        public float YearLength   // YearLength
        {
            get { return yearLength; }
            set { yearLength = value; }
        }
    }
}



/*

soilComp = random number of these from {silicate, iron, basalt, regolith, organic matter}
geography = random number of these from {mountains, valleys, impact craters, cliffs, canyons, plains}
        Ice dependent geography (water but cold) - {ice lakes, icy plains}
        Water dependent geography (water not cold) - {lakes, swamps}
Challenges = one of the following depending on the following factors
    - low gravity = {radiation}
    - low temperature = {extreme cold}
    - high water content = {storms}
Color = dependent on following
    - icy = {white, blue}
    - water = {blue}
    - rocky = {gray, red}
    - soily? = {red, brown}
Solutions = dependent, do later


*/