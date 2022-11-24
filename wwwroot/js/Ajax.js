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
    let cards = "";
    for(let i = 0; i < response.infoxPersonaje.length; i++)
    {
      cards += "<div class='card text-center border-dark mb-3' style='width: 18rem;' id='CardPersonajes'>"+
                  "<img src='/"+response.infoxPersonaje[i].foto+"' class='card-img-top' alt='...' id='imgPersonaje'>"+
                  "<p>______________________________________</p>"+
                  "<div class='card-body'>"+
                    "<h4 class='card-title' id='recompensa'> $"+response.listaPersonajes[i].recompensa+"</h4>"+
                    "<p>______________________________________</p>"+
                    "<p class='card-text'>" +response.infoxPersonaje[i].nombrePersonaje +"</p>"+
                    "<button type='button' class='btn btn-primary' onclick='mostrarInfoPersonaje("+response.infoxPersonaje[i].idPersonaje+")'>"+"Más Info"+"</button>"
                  "</div>"+
                "</div>";
          "<a href=/Home/AgregarPersonaje?IdPersonaje="+idT.toString()+" class='btn btn-primary'>Agregar Personaje</a>";
    $("#Titulo").html("Personajes");
    $("#DescripcionTemporada").html(cards);
   }
}});

}
function mostrarInfoPersonaje(idP)
{
 $.ajax(
 {
   type: 'POST',
   dataType: 'JSON',
   url: '/Home/verPersonajeInfo',
   data: {idPersonaje: idP},
   success:
   function (response)
   {


    $("#Titulo").html(response.nombrePersonaje);
    $("#DescripcionTemporada").html("<b>Haki de Armadura:</b>" + response.estadoHA +"<br/>"+ "<b>Haki de observacion:</b> " + response.estadoHO+"<br/>"+ "<b>Haki del rey:</b> " + response.estadoHR + "<br/>" + "<b>Info personaje:</b>"+ response.infoPersonaje);

   }
});
}