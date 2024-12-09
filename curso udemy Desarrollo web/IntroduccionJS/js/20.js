// Metodos de Propiedad

const reproductor = {
    reproducir : function(id){
        console.log(`La cancion sonando es ${id}`);
    },
    pausar : function(){
        console.log("pausando..")
    },
    crearPlaylist : function(name){
        console.log(`Creando la playlist: ${name}`)
    },
    reproducirPlaylist : function(name){
        console.log(`Sonando la playlist: ${name}`)
    }
}

reproductor.borrarCancion = function(id){
    console.log(`Eliminando la cancion: ${id}`)
}

reproductor.reproducir(3840);
reproductor.pausar();
reproductor.borrarCancion(20);
reproductor.crearPlaylist("Old School");
reproductor.reproducirPlaylist("Old School");