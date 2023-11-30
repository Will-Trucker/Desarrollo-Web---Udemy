// Arreglos o Arrays

const numeros = [10,20,30,40,50];


console.table(numeros);

const meses = ["Enero", "Febrero", "Marzo", "Abril", "Mayo"];
console.table(meses);

// Acceder a los valores de un arreglo
console.log(numeros[1]);
console.log(numeros[2]);
console.log(numeros[3]);
console.log(numeros[4]);


// Conocer la extension de un arreglo
console.log(meses.length);

numeros.forEach(function(numero){
  console.log(numero)
});