# PlanetGenesis

## The Challenge: Titan City, 3023
We are only just beginning to consider long-term habitation on the Moon and Mars, but what would be required in the distant future for successful exploration of even more remote planets or the icy moons of the gas giants, such as Saturn’s moon Titan? Your challenge is to create an educational game (digital or analog) that poses these challenges, explores potential solutions, and inspires new generations of space explorers.

## High-Level Summary

Since the dawn of the human race, the cosmos has always been an object of mysticism and wonder. Our team, however, would like to help accelerate the transformation of Space being an object of myths to reality. PlanetGenesis is a game that scientists can use to predict habitat ideas in planets existing in G, K, F, and M as well as planets or celestial bodies in our Solar System. Our large database of random planets referenced from real-life exoplanets will also allow the new generations of space explorers to be able to understand how the various characteristics of planets or celestial bodies such as the magnetic field, gravity, temperature, presence of biotic chemicals, topography, and soil composition will influence habitat design and structure. PlanetGenesis is a direct answer to the 3023 Tian City Challenge by inspiring new generations of explorers through broadening the horizon of interplanetary settlement to the far corners of our solar system and beyond in other stars and galaxies. In addition, the application integrates not astronomy but physics, biology, and engineering necessary to understand human settlement creation on other planets. The application also fosters the spirit of exploration as it prompts the user to test all of the potential habitats on unlimited randomly generated planets. Planet Genesis is important to the field of science due to its assistance in risk assessment of planet settlement and to the new generation, a platform for ideation as they build upon their habitat ideas with the foundational information in the application.

## Project Demo

See Video [here.](https://www.youtube.com/watch?v=xdDqAAhp0p4)

## Impact

PlanetGenesis solves the Titan City Challenge by providing a 3D interface of the planets in our solar system with comprehensive information about settling on the planet. In other words, it is a living Britannica for space enthusiasts to discover the habitat concepts and challenges to survive on other planets. This application encourages interdisciplinary learning as the knowledge of Physics, Biology, Environmental Science, and Engineering are used in conjunction with astronomy to construct the Habitat.

## Future Implementation
Currently, we cannot say that the application is fully completed. Given the time limitation, we are unable to fully implement the random planet generator which would allow users to access the random planet button in the application and generate random planets in G, K, F, and M star types given random variables of

1. Mass
2. Radius
3. Magnetic Field
4. Gravity
5. Temperature (°C)
6. Oxygen Level (%)
7. Soil Composition
8. Topography (Mountains m, Trenches m) or geography
9. Climate
10. Distance from Star (AU)
11. Color
12. Day Length (hours)
13. Year Length (days)

Here is a snippet of our code created in C# in Unity and VSCODE

![Code Snippet](https://assets.spaceappschallenge.org/media/images/image_7anYNOQ.width-1024.png)

Another future implementation aspect of this program is that users will be able to input their own data into the application and then generate a random planet with a matched habitat description. For this purpose, we have already successfully created the datasheet for all of the randomly generated planets based on specific parameters to reference when we implement the random function in the program:

Link to datasheet: [here](https://docs.google.com/spreadsheets/d/1By3mx5X5dLw4I34GYa8BLo-NaE4WFG4acDkVzNBpuI8/edit?usp=sharing)


## What do we hope to achieve?

The RBHS Space Explorers team hopes to break down the educational barrier to understanding interplanetary settlement and generate an impact across the globe. We hope to create an open-source platform where students can learn about settling on other planets and solidify their vision of space exploration. We hope that with the full completion of the application, students will be able to fully partake in the wonderful art of exploration as they traverse across the cosmos to randomly generated planets.

## Tools used

Our project is a simulation that is designed to explore the challenges of extraterrestrial colonization. We utilized data from the known planets in our solar system to generate planetary profiles. These profiles are compared to the values of randomly generated planets to determine sustainability on that planet. The main programs that went into developing the app are Unity, Dalle for images, and Canva for GUI. All of the programming that was done was written in C#. In addition, the 3D model found in the application is created using Blender. From the player's perspective, they gain knowledge on the challenges of colonization on outer planets, as well as an understanding of how these challenges could be overcome. We hope that this could be used on a larger scale to determine the habitability of planets outside the Goldilocks zone and expand the range of our habitable range.

### Use of Artificial Intelligence

Our project integrates Artificial Intelligence in two key regards, habitat visualization image using DALLl-E 3 and the training of LLMs like ChatGPT 4 to accurately produce habitat descriptions given accurate data. For instance, for the planets that do not have a magnetic field, we trained the AI to include in the paragraph that the habitat must be constructed underground. We have also trained the AI to generate responses to other variables like temperature, oxygen level (%), soil composition, topography (Mountains m, Trenches m), climate, and distance from Star (AU) which will influence temperature. Because we understand the risk that LLMs pose to data accuracy, all data that were fed into the AI are from reliable space agencies. AI was only used in piecing together data gathered from academic sources and reliable space agencies to create a clear and concise habitat description. With this methodology, we are able to generate a limitless number of planets and accurate habitat descriptions that will help broaden the horizon of space exploration.

### Space Agency Data
- [NASA Planetary Fact Sheet](https://nssdc.gsfc.nasa.gov/planetary/factsheet/)
- [ESA Gaia Archive](https://gea.esac.esa.int/archive/)
- [NASA PDS](https://pds.nasa.gov/)
- [NASA Exoplanet Archive](https://exoplanetarchive.ipac.caltech.edu/)

## References
- [Academic Resource: Exoplanet Reference 1](https://iopscience.iop.org/article/10.3847/2041-8213/ab2df7/meta)
- [Academic Resource: M-Star Reference](https://www.sciencedirect.com/science/article/abs/pii/S0370157316303179)
- [Academic Resource: Exoplanet Reference 2](https://arxiv.org/abs/0906.2263)
- [All Non-Copyrighted Images used in the Creation of the Application](https://drive.google.com/drive/folders/1b5iBZ3dmRjnDf9tBD_bqWa6Lc-xcjuXb)
- [GUI (Non-Copyrighted) Provided by Canva](https://www.canva.com/design/DAFwdd7ZXR4/kVr4R0X8h4bwWzzmlxhQfg/edit?amp;utm_campaign=designshare&amp;utm_medium=link2&amp;utm_source=sharebutton)


# The Team

We are the RBHS Space Explorers, a group of friends from Rancho Bernardo High School. 

- Peyton Slape (Lead Programmer)
- Pukaphol (Volk) Thienpreecha (Lead Designer)
- Ishaan Lingichetty (Designer)
- Yatish Reddy Yanamala (Designer)
- Nathan Gillespie (Programmer)
- Sahanav Ramesh (Programmer)
