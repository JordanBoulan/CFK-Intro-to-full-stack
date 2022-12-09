// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function validation() {
    var username = document.getElementById("username");
    var username_error = document.getElementById("error_username");
    // validate username
    if (username.value == "") {
        username.style.border = "1px solid red";
        username.style.color = "red";
        username_error.textContent = "Username is required";
        username_error.style.color = "red";
        username.focus();
        return false;
    }
    else {
        if (username.value.length <= 5) {
            username_error.innerHTML = "Username is too short.";
            username_error.style.color = "#FF0000"; //red color
            return false;
        }
        else {
            username.style.border = "1px solid #ced4da";
            username.style.color = "#495057";
            username_error.textContent = "";
        }
    }
}