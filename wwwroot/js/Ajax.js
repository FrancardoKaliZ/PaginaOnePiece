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
/* Set the width of the side navigation to 250px and the left margin of the page content to 250px */
function openNav() {
  document.getElementById("mySidenav").style.width = "250px";
  document.getElementById("main").style.marginLeft = "250px";
}

/* Set the width of the side navigation to 0 and the left margin of the page content to 0 */
function closeNav() {
  document.getElementById("mySidenav").style.width = "0";
  document.getElementById("main").style.marginLeft = "0";
}
