
// Declaración de la función
sumar(); // Aquí manda a llamar a la función
function sumar(){
    console.log(10 * 10);
}



// Expresion de la función
sumar2();
const sumar2 = function(){ // Esto lo toma como una variable, lo que arroja undefined
    console.log( 3 + 3);
}



// IIFE
(function(){
 console.log('Esto es una función');
})();

