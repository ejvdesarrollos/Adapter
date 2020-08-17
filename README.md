# Adapter
Patrón de comando

Tengo una Interfaz y un objeto que implementa esa interfaz.
Me dan una nueva clase que es una versión mejorada, pero resulta que debe entender la interfaz que está funcionando.
Entonces creo una clase 3 que implemente la interfaz, pero en esa implementación encapsulo:
1. Creo internamente el objeto de la versión mejorada.
2. Al implementar el método de interfaz, adapto dentro el pase al método de la versión mejorada.
En la llamada del main, puedo hacer uso de la misma interfaz, pero llamando tanto al objeto actual como el nuevo.
