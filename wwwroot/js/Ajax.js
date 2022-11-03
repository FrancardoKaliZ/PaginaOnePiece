function mostrarInfoTemporada(idT)
{
 $.ajax(
 {
   type: 'POST',
   dataType: 'JSON',
   url: 'HOME/verInformacionAjax',
   data: {idTemporada: idT},
   success:
   function (response)
   {
    $("#Titulo").html("Informacion de la temporada");
    $("#DescripcionTemporada").html(response.nombre + "<br>" + response.fechaInicio + "<br>" + response.fehcaFin + "<br>" + response.infoTemporada + "<br>" + response.capitulos);

   }
});
}

function mostrarPersonajes(idT)
{
 $.ajax(
 {
   type: 'POST',
   dataType: 'JSON',
   url: 'HOME/verPersonajesAjax',
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