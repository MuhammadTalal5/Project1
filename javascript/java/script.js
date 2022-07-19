
function validatePassword(){
    const password = document.getElementById('exampleInputPassword1')
    const passwordError = document.getElementById('passwordError')
    if (password.value.length<=6)
    {
        passwordError.hidden = false
    }else{
        passwordError.hidden = true
    }
}   

function validateDOB(){
    const date = document.getElementById('exampleInputDOB1')
    const dobError = document.getElementById('DOBError')
    if (date.value == '')
    {
        dobError.hidden = false
    }else{
        dobError.hidden = true
    }
}

function validateCheckButtons(){
    const indCheck = document.getElementById('indcheck')
    const insCheck = document.getElementById('inscheck')
    const checkError = document.getElementById('checkError')
    if(indCheck.checked || insCheck.checked){
        checkError.hidden = true
    }else{
        checkError.hidden = false
    }
}

function submitForm(event){
    const email = document.getElementById('exampleInputEmail1')
    const password = document.getElementById('exampleInputPassword1')
    const date = document.getElementById('exampleInputDOB1')
    const interest = document.getElementById('interest')
    const indCheck = document.getElementById('indcheck')
    const insCheck = document.getElementById('inscheck')

    event.preventDefault();
    validateDOB();
    validateCheckButtons();
    window.open(`file:///C:/Users/Talal/Desktop/javascript/java/summary.html?email=${email.value}&password=${password.value}&date=${date.value}&interest=${interest.value}&type=${indCheck.checked === true ? "Individual" : "Institute"}`)
}   