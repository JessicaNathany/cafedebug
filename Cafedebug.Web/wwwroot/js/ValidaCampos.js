function ValidaCamposLogin() {
    if (document.getElementById("login").value == "" || document.getElementById("login")) {
        alert('Por favor, preencha o campo nome');
        document.getElementById("nome").focus();
        return false
    }
}