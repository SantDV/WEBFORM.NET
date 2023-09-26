
var formContact = document.getElementById('form-contact');

formContact.addEventListener("submit", 

function(event){

    event.preventDefault();

    var name = formContact.querySelector('input[name="name"').value;

    alert("nombre"+name)

})