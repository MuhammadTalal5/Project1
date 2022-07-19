function getDataFromParams(){
    var url_string = window.location.href
    var url = new URL(url_string);

    var email = url.searchParams.get("email");
    var password = url.searchParams.get("password");
    var date = url.searchParams.get("date");
    var interest = url.searchParams.get("interest");
    var type = url.searchParams.get("type");

    const emailId = document.getElementById("emailId")
    const passwordId = document.getElementById("passwordId")
    const dobId = document.getElementById("dobId")
    const intId = document.getElementById("intId")
    const typeId = document.getElementById("typeId")

    emailId.innerText = email
    passwordId.innerText = password
    dobId.innerText = date
    intId.innerText = interest
    typeId.innerText = type
}