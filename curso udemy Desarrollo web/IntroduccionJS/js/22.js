const puntaje = 100 // = Asignar una variable


// == Comparacion
// === Triple comparacion (Tomando en cuenta el tipo de valor)
// !== Diferente


// if(puntaje !== 1000){
//     console.log('No es igual')
    
// } else {
//     console.log(`Si el puntaje es ${puntaje}`);
// }

/*

 === Este tipo de simbolo comparara si el valor es el mismo, es muy estricto porque toma en cuenta el tipo de valor por ejemplo si el valor que estamos pasando es un string pero en la funcion le pasamos un int pues no ejecutara nada porque se rompe

*/

// const money = 1000;
// const cart = 800;

// if(money > 800){
//     console.log("El usuario puede pagar")
// } else {
//     console.log("Fondos insuficientes")
// }


// elseif
const rol = 'ADMINISTRADOR';
if(rol === 'ADMINISTRADOR'){
    console.log('Acceso a todo el sistema');
} else if(rol === 'EDITOR') {
    console.log('Usted puede entrar pero no tendra todos los permisos');
} else {
    console.log('Ud. no tiene acceso');
}