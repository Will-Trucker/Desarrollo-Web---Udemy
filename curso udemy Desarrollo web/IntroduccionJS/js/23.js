const paymentMethod = 'efectivo';

switch(paymentMethod){
    case 'tarjeta':
        console.log('Pagaste con Tarjeta');
        break;
    case 'cheque':
        console.log('El Usuario pagara con cheque, revisaremos los fondos primero');
        break;
    case 'efectivo':
        console.log('Pagaste con Efectivo');
        break;
    default:
        console.log('Aún no has pagado');
        break;
}