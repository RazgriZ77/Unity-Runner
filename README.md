# Unity Runner
Centraliza el loop de juego y permite añadir clases al mismo sin necesidad de MonoBehaviour.

## ¿Cómo funciona?
Este paquete añade la capacidad de que cualquier tipo de clase, siempre y cuando pueda heredar la interfaz "IRunnable", posea un método que sirve como "Update", llamado "Ticks".
Este método se puede añadir y quitar cuando se desee, lo que optimiza el flujo del juego además de centralizar el loop.

También existen interfaces para el "FixedUpdate" y el "LateUpdate".

# Instalación
1. Ve a **Unity**, en la pestaña de **"Window/Package Manager"**
2. Dale al símbolo de **"+"** y a la opción de _"Install package from git URL..."_
3. Pega el link de este repositorio ```[https://github.com/RazgriZ77/Unity-Runner.git]```
4. Pulsa en **"Install"**

# Sample
El proyecto trae consigo un ejemplo de cómo añadir una clase que no hereda de MonoBehaviour al loop de juego y, tras transcurrir varios segundos, se elimina del mismo.
