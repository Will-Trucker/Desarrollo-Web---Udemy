//Objetos
// Crear un objeto con una sola variable para contener los tres elementos
const producto = {
   nombreProducto: "Monitor 20 Pulgadas", //Propuedad del objeto
   precio : 300,
   disponible : true,
};



//console.log(producto.precio);
//console.log(producto.nombreProducto);
//console.log(producto.disponible);
// Forma obsoleta
//console.log(producto["precio"]);

// Agregar nuevas propiedades
producto.imagen = 'imagen.jpg';

// Eliminar propiedades
delete producto.disponible;

console.log(producto);