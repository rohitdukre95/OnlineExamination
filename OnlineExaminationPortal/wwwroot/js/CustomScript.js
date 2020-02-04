function confirmDelete(uniqueId, isDeleteClicked) {
    var deleteSpan = 'deleteSpan_' + uniqueId;
    var confirmDeleteSpan = 'confirmDeleteSpan_' + uniqueId;

    if (isDeleteClicked) {
        $('#' + deleteSpan).hide();
        $('#' + confirmDeleteSpan).show();
    } else {
        $('#' + deleteSpan).show();
        $('#' + confirmDeleteSpan).hide();
    }
}

$(document).ready(function () {

    $('#candidateList thead tr').clone(true).appendTo('#candidateList thead');
    $('#candidateList thead tr:eq(1) th').each(function (i) {
        var title = $(this).text();
        $(this).html('<input type="text" placeholder="Search ' + title + '" />');

        $('input', this).on('keyup change', function () {
            if (table.column(i).search() !== this.value) {
                table
                    .column(i)
                    .search(this.value)
                    .draw();
            }
        });
    });
    var table = $('#candidateList').DataTable({
        orderCellsTop: true,
        fixedHeader: true,
        dom: 'Bfrtip',
        buttons: [
            {
                extend: 'copy',
                exportOptions: {
                    columns: [0, 1, 2, 3, 4, 5, 6]
                }
            },
            {
                extend: 'csv',
                exportOptions: {
                    columns: [0, 1, 2, 3, 4, 5, 6]
                }
            },
            {
                extend: 'pdf',
                exportOptions: {
                    columns: [0, 1, 2, 3, 4, 5, 6]
                }
            },
            {
                extend: 'excel',
                exportOptions: {
                    columns: [0, 1, 2, 3, 4, 5, 6]
                }
            },
            {
                extend: 'print',
                exportOptions: {
                    columns: [0, 1, 2, 3, 4, 5, 6]
                }
            }
        ]
    });
   
});

function ShowModal(id, flag) {
    if ($("#" + id).val() != undefined) {
        var dataStr = $("#" + id).val();
        var dataArray = dataStr.split("|");
        var Id = dataArray[0];
        var PositionDescription = dataArray[1];
        $("#" + flag + "_Id").val(Id);
        $("#" + flag + "_PositionDescription").val(PositionDescription);
    }    
    $('#' + flag).modal('show');
}
function UpdateModel(actionName) {
    var flag = "";
    var Id = "";
    var PositionDescription = "";

    //urls = '@Url.Action("EditModel","Position")';
    var urls = "/Position/EditModel";
    if (actionName == "AddModel") {
        flag = "AddModal";
        //urls = '@Url.Action("DeleteModel","Position")';
        var urls = "/Position/AddModel";
    }
    if (actionName == "EditModel") {
        flag = "EditModal";
        //urls = '@Url.Action("DeleteModel","Position")';
        var urls = "/Position/EditModel";
    }
    if (actionName == "DeleteModel") {
        flag = "DeleteModal";
        //urls = '@Url.Action("DeleteModel","Position")';
        var urls = "/Position/DeleteModel";
    }
   
    if ($("#" + flag + "_Id").val() != undefined) {
        Id = $("#" + flag + "_Id").val();
    }    
    PositionDescription = $("#" + flag + "_PositionDescription").val();
    var data = new Array();
    data.push(Id, PositionDescription);
    var jsonData = JSON.stringify(data);

    $.ajax({
        type: "POST",
        url: urls,
        data: {
            "data": jsonData
        },
        success: function (r) {
            alert(r.responseText);
            location.reload(true);
        },
        error: function () {
            alert("Error");
        }
    });
}
   