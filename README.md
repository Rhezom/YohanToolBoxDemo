# YohanToolBoxDemo


CLAP :
- ClapController ==> Sur n'importe quel gameObject. Ne pas oubli� de mettre le FirstController et le SecondController
- Une variable "Set Time Between Set Last Distance" permet de ne pas set la valeur � toutes les frames ( Optimisation :P ).
- La vitesse est une moyenne calcul�e gr�ce � la distance parcourue suivant le temps �coul� ( Remis � 0 � chaque SetLastDistance )

- ClapShader ==> Require le ClapController ( D�j� mis dans le code, donc tu peux juste drag&drop le ClapShader sur l'objet)

- Si tu veux mettre un gameObject visuel, j'ai un tools qui permet de d�sactiver le mesh renderer pour qu'il soit transparent 
d�s le start avec une valeur : IsDebug. Si tu le coche, le mesh renderer est visible



SHADER :
- Chaque objet de la sc�ne dont leur material doivent devenir en Wireframe doivent avoir le script : ShaderTagMaterialManager
- Tu trouveras 4 materials wireframe dans le dossier Wireframe/example/material



PARTICLE :
- Pour le FX, vous pouvez mettre n'importe quel FX. Le script ParticleSystemManager devra quant � lui se trouver sur le gameObject contenant le Particle System




