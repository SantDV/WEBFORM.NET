function validate(){
    var name = document.getElementById('name').value;
    var email = document.getElementById('email').value
    var message = document.getElementById('message').value;

    
    if (name == "") 
    {
        alert("Debe ingresar su nombre.");
    } 
    else if (email == "") 
    {
        alert("Debe ingresar su email.");
    } 
    else if (message == "") 
    {
        alert("Debe ingresar su mensaje.");
    } 
    else 
    {
        alert("Su consulta ha sido enviada!");

    }
}