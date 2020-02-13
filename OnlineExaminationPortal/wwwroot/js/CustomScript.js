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
        if (i <= 9) {
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
        }
        else
        {
            $(this).html('');
        }
        
    });
    var table = $('#candidateList').DataTable({
        orderCellsTop: true,
        fixedHeader: true,
        dom: '<lfB<t> ip>',
        "scrollX": true,
        "lengthMenu": [[10, 25, 50, -1], [10, 25, 50, "All"]],

        buttons: [
            //{
            //    extend: 'copy',
            //    exportOptions: {
            //        columns: [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
            //    }
            //},
            //{
            //    extend: 'csv',
            //    exportOptions: {
            //        columns: [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
            //    }
            //},
            //{
            //    extend: 'pdf',
            //    orientation: 'landscape',
            //    exportOptions: {
            //        columns: [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
            //    }
            //},
            {
                extend: 'excel',
                exportOptions: {
                    columns: [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
                }
            },
            {
                extend: 'print',
                exportOptions: {
                    columns: [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
                }
            }
        ]
    });

});


function ShowPositionModal(id, flag) {
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
function UpdatePositionModal(actionName) {
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
            bootbox.alert(r.responseText, function () {
                location.reload(true);
            });

        },
        error: function () {
            alert("Error");
        }
    });
}

function ShowCandidateModal(id, flag) {
    if ($("#" + id).val() != undefined) {
        var dataStr = $("#" + id).val();
        var dataArray = dataStr.split("|");
        var Id = dataArray[0];
        var Marks = dataArray[1];
        var ExamStatus = dataArray[2];
        $("#" + flag + "_Id").val(Id);
        $("#" + flag + "_Marks").val(Marks);
        $("#" + flag + "_ExamStatus").val(ExamStatus);
    }
    $('#' + flag).modal('show');
}
function UpdateCandidateModal(actionName) {
    var flag = "";
    var Id = "";
    var ExamStatus = "";

    //urls = '@Url.Action("EditModel","Position")';
    //var urls = "/Position/EditModel";
    //if (actionName == "AddModel") {
    //    flag = "AddModal";
    //    //urls = '@Url.Action("DeleteModel","Position")';
    //    var urls = "/Position/AddModel";
    //}
    if (actionName == "EditModel") {
        flag = "EditModal";
        //urls = '@Url.Action("DeleteModel","Position")';
        var urls = "/Candidate/EditCandidate";
    }
    //if (actionName == "DeleteModel") {
    //    flag = "DeleteModal";
    //    //urls = '@Url.Action("DeleteModel","Position")';
    //    var urls = "/Position/DeleteModel";
    //}

    if ($("#" + flag + "_Id").val() != undefined) {
        Id = $("#" + flag + "_Id").val();
    }
    Marks = $("#" + flag + "_Marks").val();
    ExamStatus = $("#" + flag + "_ExamStatus").val();
    var data = new Array();
    data.push(Id, Marks, ExamStatus);
    var jsonData = JSON.stringify(data);

    $.ajax({
        type: "POST",
        url: urls,
        data: {
            "data": jsonData
        },

        success: function (r) {
            bootbox.alert("Candidate Result Updated Successfully!", function () {
                location.reload(true);
            });
        },
        error: function () {
            alert("Error");
        }
    });
}


function deleteCandidate(id) {
    bootbox.confirm({
        message: "Are you sure you want to delete this candidate?",
        callback: function (result) {
            if (result == true) {
                $.ajax({
                    type: "GET",
                    url: "/Candidate/DeleteCandidate?id=" + id,
                    success: function (r) {
                        location.reload(true);
                    },
                    error: function () {
                        alert("Error");
                    }
                });
            }
        }
    });

}

