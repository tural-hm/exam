$(document).ready(function () {
   


        $('#datepicker').datepicker({
            uiLibrary: 'bootstrap4'
    });

    $('#ImtahanModal').on('shown.bs.modal', function () {
        $.ajax({
            type: "POST",
            url: "/home/FillDers",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                console.log(data.message);
                $("#SelectDers").empty();
                $("#SelectDers").append(data.message);

            },
            error: function () {

            }
        });

        $.ajax({
            type: "POST",
            url: "/home/FillSagird",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                console.log(data.message);
                $("#SelectSagird").empty();
                $("#SelectSagird").append(data.message);

            },
            error: function () {

            }
        });
    })


   
});