// Arrow Functions

/* 
Es otra manera de declarar funciones, la sintaxis es un poco más corta 
*/

const sumar2 = (n1,n2) => console.log( n1 + n2);
sumar2(5,10);

// Estructura basica para crear un arrow function
const learning = tech => console.log(`Aprendiendo ${tech}`)


learning("PHP, JAVA, REACT");


// Array Methods

const meses = ["Enero", "Febrero", "Marzo", "Abril", "Mayo"];

const carrito = [  // Arreglo con Objetos
    {nombre: 'Monitor 20 Pulgadas', precio:500},
    {nombre: 'Televisión 50 Pulgadas', precio:700},
    {nombre: 'Tablet',precio:300},
    {nombre: 'Audifonos', precio:200},
    {nombre: 'Teclado', precio:50},
    {nombre: 'Celular', precio:500},
    {nombre: 'Bocinas', precio:300},
    {nombre: 'Laptop', precio:800}    
]; 

// forEach
meses.forEach(mes => {
    if(mes == 'Marzo'){
    console.log('Marzo si existe');
  }
});

let resultado;
// Some ideal para arreglo de objetos
resultado = carrito.some(producto => producto.nombre === 'Celular');


// Reduce
resultado = carrito.reduce((total, producto) => total + producto.precio, 0) // Valor inicial

// filter
resultado = carrito.filter(producto  => producto.precio > 400)

resultado = carrito.filter(producto => producto.nombre !== 'Celular'); // Articulos que sean diferentes a "Celular"


console.log(resultado);


