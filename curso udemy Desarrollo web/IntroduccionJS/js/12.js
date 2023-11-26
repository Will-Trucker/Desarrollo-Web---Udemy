// "use strict"; // Correr JavaScript en modo estricto
const producto = {
    nombreProducto: "Monitor 20 Pulgadas",
    precio : 300,
    disponible : true,
 };

 Object.seal(producto); // Congelar valores

 producto.precio = 'NUEVO PRECIO';

 delete producto.precio;

 console.log(producto);