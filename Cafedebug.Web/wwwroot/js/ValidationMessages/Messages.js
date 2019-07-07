// Criação da mensagem modelo de exemplo

// TODO: Ajustar

function ShowQuestion(message, title, icon, yesCallback, noCallback, closeCallback) {
    var buttons = '';
    buttons += '<button type="button" class="btn btn-success" data-dismiss="modal" data-yes>{{yesText}}</button>';
    buttons += '<button type="button" class="btn btn-danger" data-dismiss="modal" data-no>{{noText}}</button>';

    buttons = buttons.replace('{{noText}}', core_messagebox_strings.no)
        .replace('{{yesText}}', core_messagebox_strings.yes);

    var html = messageBoxBase.replace(new RegExp('{{title}}', 'g'), title)
        .replace(new RegExp('{{icon}}', 'g'), icon)
        .replace(new RegExp('{{message}}', 'g'), message)
        .replace(new RegExp('{{buttons}}', 'g'), buttons);

    $("body").append(html);

    $('#messagebox_' + icon).on('hidden.bs.modal', function () {
        if (closeCallback) closeCallback();
        $("#messagebox_" + icon).remove();
    });

    if (noCallback) {
        $('#messagebox_' + icon).find('[data-no]').on('click', function () {
            noCallback();
        });
    }
    if (yesCallback) {
        $('#messagebox_' + icon).find('[data-yes]').on('click', function () {
            yesCallback();
        });
    }

    $('#messagebox_' + icon).modal();
}

