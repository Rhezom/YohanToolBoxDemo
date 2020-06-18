# YohanToolBoxDemo


CLAP :
- ClapController ==> Sur n'importe quel gameObject. Ne pas oublié de mettre le FirstController et le SecondController
- Une variable "Set Time Between Set Last Distance" permet de ne pas set la valeur à toutes les frames ( Optimisation :P ).
- La vitesse est une moyenne calculée grâce à la distance parcourue suivant le temps écoulé ( Remis à 0 à chaque SetLastDistance )

- ClapShader ==> Require le ClapController ( Déjà mis dans le code, donc tu peux juste drag&drop le ClapShader sur l'objet)

- Si tu veux mettre un gameObject visuel, j'ai un tools qui permet de désactiver le mesh renderer pour qu'il soit transparent 
dès le start avec une valeur : IsDebug. Si tu le coche, le mesh renderer est visible



SHADER :
- Chaque objet de la scène dont leur material doivent devenir en Wireframe doivent avoir le script : ShaderTagMaterialManager
- Tu trouveras 4 materials wireframe dans le dossier Wireframe/example/material



PARTICLE :
- Pour le FX, vous pouvez mettre n'importe quel FX. Le script ParticleSystemManager devra quant à lui se trouver sur le gameObject contenant le Particle System




