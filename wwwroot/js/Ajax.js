function mostrarInfoTemporada(idT)
{
 $.ajax(
 {
   type: 'POST',
   dataType: 'JSON',
   url: '/Home/mostrarInfoTemporadaAjax',
   data: {idTemporada: idT},
   success:
   function (response)
   {
    $("#Titulo").html("Informacion de la temporada");
    $("#DescripcionTemporada").html(response.nombreTemporada + "<br>" + response.fechaInicio.substr(0, 10) + "<br>" + response.fechaFin.substr(0,10) + "<br>" + response.infoTemporada + "<br>" + "capitulos: " + response.capitulos);

   }
});
}

function mostrarPersonajes(idT)
{
 $.ajax(
 {
   type: 'POST',
   dataType: 'JSON',
   url: '/Home/verPersonajesAjax',
   data: {idTemporada: idT},
   success:
   function (response)
   {
    var actor = "";
    response.forEach(element => {
      personaje += element.nombre + "<br/>" + element.info + "<br/>" + element.raza ;
    });
    $("#Titulo").html("Personajes");
    $("#DescripcionTemporada").html(personaje);
   }
})
}