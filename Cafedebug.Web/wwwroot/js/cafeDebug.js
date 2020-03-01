
$(function () {

    $("img").on("error", function () {
        $(this).attr("src", "~/images/Spinner.gif");
    });

    

});

