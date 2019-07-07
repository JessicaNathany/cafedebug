function MontarMensagem() {

    var MontarDivMensagens = "";

    MontarDivMensagens += 
        "<div id='mensagem-warning' class=' alert alert-warning alert-dismissible fade hide' role='alert' style='display: none; tabindex=' - 1' role='dialog '>" +
        "<h4 align='left' class='alert-heading'>Atenção!</h4><hr>" +
        "<p id='text-mensagem-warning'></p>" +
        "<button type='button' class='close' data-dismiss='mensagem-warning' aria-label='Close'>" +
        "<span aria-hidden='true'>&times;</span>" +
        "</button>" +
        "</div>" +
        "<div id='mensagem-danger' class='alert alert-danger alert-dismissible fade hide' role='alert' style='display: none;' >" +
        "<h4 class='alert-heading'> Atenção!</h4><hr>" +
        "<p id='text-mensagem-danger'></p>" +
        "<button type='button' class='close' data-dismiss='modal' aria-label='Close'>" +
        "<span align='left' aria-hidden='true'>&times;</span>" +
        "</button>" +
        "</div>" +
        "<div id='mensagem-success' class='alert alert-success alert-dismissible fade hide' role='alert' style='display: none;' >" +
        "<h4 class='alert-heading'> Atenção!</h4><hr>" +
        "<p id='text-mensagem-success'></p>" +
        "<button type='button' align='right' class='close' data-dismiss='mensagem-success' aria-label='Close'>" +
        "<span aria-hidden='true'>&times;</span>" +
        "</button>" +
        "</div>";

    document.getElementById("exibir-mensagem").innerHTML = "";
    document.getElementById("exibir-mensagem").innerHTML = MontarDivMensagens;

}


function ExibirPopUpWarning(mensagem) {

    MontarMensagem();

    document.getElementById("text-mensagem-warning").innerHTML = mensagem;

    $('.alert-warning').alert();
    $('#mensagem-warning').removeClass('hide');
    $('#mensagem-warning').addClass('show');
    $('#mensagem-warning').css('display', 'block');
    $("#mensagem-warning").show();

    $(".close").click(function () {
        $('.alert-warning').alert('close');
    });
}


function ExibirPopUpDanger(mensagem) {

    MontarMensagem();

    document.getElementById("text-mensagem-danger").innerHTML = mensagem;

    $('.alert-danger').alert();
    $('#mensagem-danger').removeClass('hide');
    $('#mensagem-danger').addClass('show');
    $('#mensagem-danger').css('display', 'block');
    $("#mensagem-danger").show();

    $(".close").click(function () {
        $('.alert-danger').alert('close');
    });
}


function ExibirPopUpSuccess(mensagem) {

    MontarMensagem();

    document.getElementById("text-mensagem-success").innerHTML = mensagem;

    $('.alert-success').alert();
    $('#mensagem-success').removeClass('hide');
    $('#mensagem-success').addClass('show');
    $('#mensagem-success').css('display', 'block');
    $("#mensagem-success").show();

    $(".close").click(function () {
        $('.alert-success').alert('close');
    });
}