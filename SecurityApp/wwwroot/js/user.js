function submitUser() {
    var userName = document.getElementById('txtUserName');
    var password = document.getElementById('txtPassword');
    if (validateUserName(userName) && validatePassword(password)) {
        alert('Validation Passed & Form Submitted');
    }
    else {
        alert('Validation enter correct UserName and Password');
    }
}