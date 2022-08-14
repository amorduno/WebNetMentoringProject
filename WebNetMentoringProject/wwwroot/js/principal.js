var modal;
var img;
var modalImg;
var captionText;
var span;


$(document).ready(function () {
    // Initialize Tooltip
    $('[data-toggle="tooltip"]').tooltip();

    // Add smooth scrolling to all links in navbar + footer link
    $(".navbar a, footer a[href='#myPage']").on('click', function (event) {

        if (this.hash !== "") {

            // Prevent default anchor click behavior
            event.preventDefault();

            // Store hash
            var hash = this.hash;

            // Using jQuery's animate() method to add smooth page scroll
            // The optional number (900) specifies the number of milliseconds it takes to scroll to the specified area
            $('html, body').animate({
                scrollTop: $(hash).offset().top
            }, 900, function () {

                // Add hash (#) to URL when done scrolling (default click behavior)
                window.location.hash = hash;
            });
        } // End if
    });

    $("#supportWP").hide();
    $("#phoneWP").hide();
    $("#locationWP").hide();

    var btnContact, btnSupport, btnPhone, btnLocation;

    btnContact = document.getElementById("btnContact");
    btnSupport = document.getElementById("btnSupport");
    btnPhone = document.getElementById("btnPhone");
    btnLocation = document.getElementById("btnLocation");

    btnContact.onclick = Contact;
    btnSupport.onclick = Contact;
    btnPhone.onclick = Contact;
    btnLocation.onclick = Contact;



    modal = document.getElementById('myModal');

    img = document.getElementById('SCPO');
    //modalImg = document.getElementById("img01");
    captionText = document.getElementById("caption");
    infoText = document.getElementById("info");

    img.onclick = openModal;


    span = document.getElementsByClassName("close")[0];

    span.onclick = closeModal;
})


function Contact(event) {
    var option = event.target.id;
    switch (option) {
        case "btnContact":
            $("#contactWP").show();
            $("#supportWP").hide();
            $("#phoneWP").hide();
            $("#locationWP").hide();
            break;
        case "btnSupport":
            $("#contactWP").hide();
            $("#supportWP").show();
            $("#phoneWP").hide();
            $("#locationWP").hide();
            break;
        case "btnPhone":
            $("#contactWP").hide();
            $("#supportWP").hide();
            $("#phoneWP").show();
            $("#locationWP").hide();
            break;
        case "btnLocation":
            $("#contactWP").hide();
            $("#supportWP").hide();
            $("#phoneWP").hide();
            $("#locationWP").show();
            break;
    }
}



function openModal(event) {
    var option = event.currentTarget.id;
    modal.style.display = "block";



    switch (option) {
        case "SCPO":
            infoText.innerHTML = "<p><strong>Asignación</strong></p>";
            + "<p> "
                + "El sistema de Asignación de uniformes permite la entrega y asignación personalizada de uniformes a cada uno de los elementos pertenecientes a determinada organización/institución que han sido registrados previamente en el sistema. "
                + "La asignación de las prendas se realiza a través de estaciones de trabajo especializadas que garantizan el proceso y resguardo de la información, esto se logra mediante la lectura de códigos COAS (Código Óptico de Alta Seguridad) y códigos QR (Quick Response) que se encuentran en las prendas del uniforme, quedando registro de la cantidad de prendas y las respectivas tallas entregadas. "
                + "El sistema de Registro y Asignación de elementos valida la identidad del elemento al que se le entrega el uniforme mediante la lectura de la huella dactilar, de esta forma se garantiza que cada uno de los uniformes es entregado a la persona correcta. Al terminar el proceso de asignación se emite un comprobante con toda la información registrada como validación de los artículos entregados. "
                + "La trazabilidad de artículos es posible gracias al código óptico de alta seguridad (COAS) que presenta cada prenda y que la hace única e identificable desde el proceso de manufactura y distribución hasta la asignación (entrega al elemento correspondiente). "
                + "</p>";
            captionText.innerHTML = "Asignaciones";
            break;
        case "SIAS":
            alert("SIAS");
            break;
        case "REPUVE":
            alert("REPUVE");
            break;
        case "TGS":
            alert("TGS");
            break;
        case "SMVI":
            alert("SMVI");
            break;
        case "STI":
            alert("STI");
            break;
    }

}

function closeModal() {
    modal.style.display = "none";
}