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
    console.log(response);
    var personaje = "";
    for(let i = 0; i < response.infoxPersonaje.length; i++)
    {
      personaje += "Nombre: " + response.infoxPersonaje[i].nombrePersonaje + "<br/>" + "Recompensa: " + response.listaPersonajes[i].recompensa + "<br/>" + "Haki de Armadura: " + response.listaPersonajes[i].estadoHA;
    }
    $("#Titulo").html("Personajes");
    $("#DescripcionTemporada").html(personaje);
   }
})
}