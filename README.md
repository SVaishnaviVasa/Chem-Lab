# Chem-Lab
 Chemistry lab setup made using unity to perform chemical reactions

Step 1: Project Setup
 - Create a New Unity Project:
    Open Unity Hub and create a new 3D project.
 - Setup Scene:
   Add a Plane to represent the floor.
   Create a Table model or use a 3D asset and place it in the scene.
   Add conical flask and test tube models to the scene on the table.
 - Import and Setup Character:
   Import your rigged 3D character and animations.
   Position the character next to the table.
 - Materials and Textures:
   Apply realistic materials and textures to the flasks, test tubes, table, and floor.
 - Lighting:
   Add directional light for a realistic lighting effect.
   Optionally, add point lights or spotlights for additional effects.

Step 2: Scripting and Interactions
 Main Components:
   - ObjectInteractionController.cs - Manages the interaction with objects.
     Object: Attach this script to a central GameObject in your scene, often the main camera or a dedicated controller GameObject. This script is responsible for detecting  mouse inputs and should be in a position to always be active, monitoring user interactions.
     Purpose: Handles user inputs and raycasts to detect clicks on interactive objects.

   - ChemistryReaction.cs - Handles the chemistry reactions for color change and smell.
     Objects: Attach this script to each of the conical flasks and the test tube. Ensure each of these objects has a Collider component (such as a BoxCollider or MeshCollider) that is set to be triggerable.
     Purpose: Manages the chemical reactions, including color changes and smell emissions. For the color change, make sure that the objects have a Renderer with a Material whose color can be changed.
     
   - CharacterAnimationController.cs - Manages character animations and expressions.
     Object: Attach this script to your rigged 3D character.
     Purpose: Controls the character's animations and expressions based on the state of the interactions (e.g., reacting to the smell, showing excitement at the color change).
     
   - CameraMovement.cs- Handles movement in the Game play through keyboard A,W,S,D keys
     This script will allow you to move the camera in the scene, giving the impression that you are walking around the lab.

Step 3: Attaching files
  Attach the script files as mentioned above. Also check if the colliders are enabled in the objects like conical flasks and test tubes

<img width="740" alt="1" src="https://github.com/SVaishnaviVasa/Chem-Lab/assets/120392585/e280a427-42af-4a36-b93f-de5ced81f481">

<img width="733" alt="2" src="https://github.com/SVaishnaviVasa/Chem-Lab/assets/120392585/f7beb336-0ed0-450c-9961-0089ac39a975">

(Lab Setup which contains lab, conical flasks, test tubes, 3D character etc. Provided in Prefab, Assets -> Prefabs -> Setup)

<img width="369" alt="3" src="https://github.com/SVaishnaviVasa/Chem-Lab/assets/120392585/29dfc411-9d06-48b3-9789-1524a5cee250">

(Particle effect for smell)

<img width="737" alt="4" src="https://github.com/SVaishnaviVasa/Chem-Lab/assets/120392585/4bad00fd-d43a-4f3c-bbb4-3c01c5ef6003">

<img width="730" alt="Screenshot 2024-04-15 170731" src="https://github.com/SVaishnaviVasa/Chem-Lab/assets/120392585/af5dfece-1126-4b9d-b7b3-e7c98359ac4e">

(The interactions are being shown in console {as of now})

Future Scope/Implementations :-
 - Still working on interactability through ray casting using mouse
 - Physics simulations for flowing of fluid/chemical from one conical flask to another or from test tube
 - 3D character animation for showing interactability with equipments
 - Better chemical reactions simulation based on changing liquids
 - Including XR plugin to implement VR options for better understanding

Scripts used:-
 - CameraMovement.cs
 - Interactable.cs
 - CharacterAnimationController.cs
 - ChemistryReaction.cs
(These can be accessed by following: Assets -> Scripts)





