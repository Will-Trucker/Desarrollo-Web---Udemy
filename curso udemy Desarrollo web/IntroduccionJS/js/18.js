// Declaración de la función

function sumar(numero1 = 0, numero2 = 0){ // numero1, 2 son parametros
    console.log(numero1 + numero2);
}
sumar(); // Argumentos
sumar(3,3); // Argumentos
sumar(3,6); // Argumentos
sumar(1); // Argumentos



// Expresion de la función
const sumar2 = function(n1, n2){ 
    console.log(n1 + n2);
}
sumar2(5,10);
