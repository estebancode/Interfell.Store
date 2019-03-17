$(document).ready(function () {

    LoadArticles();

    //Método que permite validar que solo se ingresen núemeros en el campo donde se ponga la clase .numerico
    $('body').on('keypress', '.number-validation', function (key) {
        var charCode = key.charCode;
        if (charCode > 31 && (charCode < 48 || charCode > 57))
            return false;
    });


    $('body').on('click', '#createArticle', function () {

        if ($("#name").val() == '') {
            alert("Field name is required");
            return false;
        }

        if ($("#description").val() == '') {
            alert("Field description is required");
            return false;
        }

        if ($("#price").val() == '') {
            alert("Field price is required");
            return false;
        }

        if ($("#totalinshelf").val() == '') {
            alert("Field total in shelf is required");
            return false;
        }

        if ($("#totalinvault").val() == '') {
            alert("Field total in vault is required");
            return false;
        }

        CreateArticle();

    });


    $('body').on('click', '.CallEditArticle', function () {

        $("#description-edit").val('');
        $("#name-edit").val('');
        $("#id-edit").val('');
        $("#price-edit").val('');
        $("#totalinshelf-edit").val('');
        $("#totalinvault-edit").val('');

        $('#id-edit').val($(this).attr('data-id'));
        $('#name-edit').val($(this).attr('data-name'));
        $('#description-edit').val($(this).attr('data-description'));
        $("#price-edit").val($(this).attr('data-price'));
        $("#totalinshelf-edit").val($(this).attr('data-totalinshelf'));
        $("#totalinvault-edit").val($(this).attr('data-totalinvault'));

        $("#modalUpdateArticle").modal('show');

    });

    $('body').on('click', '#updateArticle', function () {

        if ($("#name-edit").val() == '') {
            alert("Field name is required");
            return false;
        }

        if ($("#description-edit").val() == '') {
            alert("Field description is required");
            return false;
        }

        if ($("#price-edit").val() == '') {
            alert("Field price is required");
            return false;
        }

        if ($("#totalinshelf-edit").val() == '') {
            alert("Field total in shelf is required");
            return false;
        }

        if ($("#totalinvault-edit").val() == '') {
            alert("Field total in vault is required");
            return false;
        }

        var articleDTO = {
            'IdArticle': $('#id-edit').val(),
            'Name': $("#name-edit").val(),
            'Description': $("#description-edit").val(),
            'Price': $("#price-edit").val(),
            'TotalInShelf': $("#totalinshelf-edit").val(),
            'TotalInVault': $("#totalinvault-edit").val(),
        };

        CallEditArticle($('#id-edit').val(), articleDTO);

    });

});

function LoadArticles() {

    $.ajax({
        url: "/Services/Articles/Stores/" + $('#IdStore').val(),
        type: "GET",
    }).done(function (response) {

        $('.table-body-articles').html(' ');

        if (response.Header.Success) {

            $.each($(response.Data), function (x, y) {
                $('.table-body-articles').append('<tr>' +
                    '<td>' + y.IdArticle + '</td>' +
                    '<td>' + y.Name + '</td>' +
                    '<td>' + y.Description + '</td>' +
                    '<td>' + y.Price + '</td>' +
                    '<td>' + y.TotalInShelf + '</td>' +
                    '<td>' + y.TotalInVault + '</td>' +
                    '<td>' +
                    '<button class="btn btn-warning btn-xs CallEditArticle" data-id="' + y.IdArticle + '" data-name="' + y.Name + '" data-description="' + y.Description + '" data-price="' + y.Price + '"  data-totalinshelf="' + y.TotalInShelf + '"  data-totalinvault="' + y.TotalInVault + '" type="button"><span class="glyphicon glyphicon-edit"></span></button> ' +
                    '</td > ' +
                    '</td>');
            });

        } else {

            $(".table-body-articles").append('<tr> <td colspan="7" > No hay elementos </td> </tr>');
        }

    });


}

function CreateArticle() {

    $.ajax({
        url: "/Services/Articles/",
        type: "POST",
        datatype: "application/json",
        data: {
            'Name': $("#name").val(),
            'Description': $("#description").val(),
            'Price': $("#price").val(),
            'TotalInShelf': $("#totalinshelf").val(),
            'TotalInVault': $("#totalinvault").val(),
            'StoreId': $('#IdStore').val(),
        }
    }).done(function (response) {

        if (response.Header.Success) {
            $("#modalCreateArticle").modal('hide');
            $("#description").val('');
            $("#name").val('');
            $("#price").val('');
            $("#totalinshelf").val('');
            $("#totalinvault").val('');
            LoadArticles();
        } else {
            alert(response.Header.Message);
        }
    });

}


function CallEditArticle(id, articleDTO) {

    $.ajax({
        url: "/Services/Articles/" + id,
        type: "PUT",
        datatype: "application/json",
        data: articleDTO
    }).done(function (response) {

        if (response.Header.Success) {
            $("#modalUpdateArticle").modal('hide');
            $("#description-edit").val('');
            $("#name-edit").val('');
            $("#id-edit").val('');
            $("#price-edit").val('');
            $("#totalinshelf-edit").val('');
            $("#totalinvault-edit").val('');
            LoadArticles();
        } else {
            alert(response.Header.Message);
        }
    });

}