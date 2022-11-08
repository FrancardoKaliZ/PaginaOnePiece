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
    $("#DescripcionTemporada").html("<b>Nombre: </b> "+ response.nombreTemporada + "<br>" + "<b>Fecha inicio:</b> " + response.fechaInicio.substr(0, 10) + "<br>" + "<b>Fecha fin:</b> " + response.fechaFin.substr(0,10) + "<br>" + "<b>Info temporada:</b> " + response.infoTemporada + "<br>" + "<b>capitulos:</b> " + response.capitulos);

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
    var personaje = "";
    for(let i = 0; i < response.infoxPersonaje.length; i++)
    {
      personaje += "<b>Nombre:</b> " + response.infoxPersonaje[i].nombrePersonaje + "<br/>" + "<b>Recompensa:</b> " + response.listaPersonajes[i].recompensa + "<br/>" + "<b>Haki de Armadura:</b> " + response.listaPersonajes[i].estadoHA +"<br/>"+ "<b>Haki de observacion:</b> " + response.listaPersonajes[i].estadoHO+"<br/>"+ "<b>Haki del rey:</b> " + response.listaPersonajes[i].estadoHR
      +response.infoxPersonaje[i].foto
      ;
    }
    $("#Titulo").html("Personajes");
    $("#DescripcionTemporada").html(personaje);
   }
})
}