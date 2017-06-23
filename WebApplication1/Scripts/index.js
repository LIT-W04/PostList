$(function() {
    $("#add-flavor").on('click', function() {
        $("#submit-button").before($("#template").html());
    });
});