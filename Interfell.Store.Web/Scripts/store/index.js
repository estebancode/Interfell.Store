$(document).ready(function () {

    LoadStores();

    $('body').on('click', '#createStore', function () {

        if ($("#name").val() == '') {
            alert("Field name is required");
            return false;
        }

        if ($("#address").val() == '') {
            alert("Field address is required");
            return false;
        }

        CreateStore();

    });

    $('body').on('click', '.CallEditStore', function () {

        $("#address-edit").val('');
        $("#name-edit").val('');
        $("#id-edit").val('');

        $('#id-edit').val($(this).attr('data-id'));
        $('#name-edit').val($(this).attr('data-name'));
        $('#address-edit').val($(this).attr('data-address'));

        $("#modalUpdateStore").modal('show');

    });


    $('body').on('click', '#updateStore', function () {

        if ($("#name-edit").val() == '') {
            alert("Field name is required");
            return false;
        }

        if ($("#address-edit").val() == '') {
            alert("Field address is required");
            return false;
        }

        var storeDTO = {
            'IdStore': $('#id-edit').val(),
            'Name': $("#name-edit").val(),
            'Address': $("#address-edit").val(),
        };

        CallEditStore($('#id-edit').val(), storeDTO);

    });

});


function LoadStores() {

    $.ajax({
        url: "/Services/Stores/",
        type: "GET",
    }).done(function (response) {

        $('.table-body-stores').html(' ');

        if (response.Header.Success) {

            $.each($(response.Data), function (x, y) {
                $('.table-body-stores').append('<tr>' +
                    '<td>' + y.IdStore + '</td>' +
                    '<td>' + y.Name + '</td>' +
                    '<td>' + y.Address + '</td>' +
                    '<td>' +
                    '<button class="btn btn-warning btn-xs CallEditStore" data-id="' + y.IdStore + '" data-name="' + y.Name + '" data-address="' + y.Address + '"  type="button"><span class="glyphicon glyphicon-edit"></span></button> ' +
                    '<a href="/Store/Detail/' +  y.IdStore +'" class="btn btn-info btn-xs"><span class="glyphicon glyphicon-eye-open"></span></a>' +
                    '</td > ' +
                    '</td>');
            });

        } else {

            $(".table-body-stores").append('<tr> <td colspan="4" > No hay elementos </td> </tr>');
        }

    });

}


function CreateStore() {

    $.ajax({
        url: "/Services/Stores/",
        type: "POST",
        datatype: "application/json",
        data: {
            'Name': $("#name").val(),
            'Address': $("#address").val(),
        }
    }).done(function (response) {

        if (response.Header.Success) {
            $("#modalCreateStore").modal('hide');
            $("#address").val('');
            $("#name").val('');
            LoadStores();
        } else {
            alert(response.Header.Message);
        }
    });

}


function CallEditStore(id,storeDTO) {

    $.ajax({
        url: "/Services/Stores/" + id,
        type: "PUT",
        datatype: "application/json",
        data: storeDTO
    }).done(function (response) {

        if (response.Header.Success) {
            $("#modalUpdateStore").modal('hide');
            $("#address-edit").val('');
            $("#name-edit").val('');
            LoadStores();
        } else {
            alert(response.Header.Message);
        }
    });

}