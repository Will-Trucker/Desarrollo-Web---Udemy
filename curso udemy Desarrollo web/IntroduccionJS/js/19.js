// function sumar(n1,n2){
//     return n1 + n2;
// }

// const resultado = sumar(2,4);

// console.log(resultado);

let total = 0;

function addCart(precio){
    return total += precio;
}

function taxes(total){
    return 1.15 * total;
}

total = addCart(20);
total = addCart(10);
total = addCart(200);
total = addCart(400);


console.log(total);

const toPay = taxes(total);

console.log(`El total a pagar con impuestos es: $ ${toPay}`);
