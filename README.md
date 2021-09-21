# Trombo14-Practica_IV_Asp.net

## En un proyecto de consola:

 1- Hacer un método extendido que opere sobre el tipo `List<int>` llamado `Pares()` que retorne un `List<int>` con los valores pares en la lista asociada dada. En la implementación del método `Pares()` utilice el método  `FindAll()` de las listas para pasarle una función predicado mediante la implementación de un delegado que represente métodos que retornen bool y que reciban un entero como parámetro.


2 -  Escriba los siguiente método como expresión lambda:
```
public bool EsImpar(int x){
     if (x % 2 != 0){
         return true;
     else{
         return false;
     }
}


public double CalcularITBIS(double precio){
    var itebis = precio * 0.18;
    return itebis;
}


public void GetDate(){
     var fecha = DateTime.Now;
     return fecha;
}
```
