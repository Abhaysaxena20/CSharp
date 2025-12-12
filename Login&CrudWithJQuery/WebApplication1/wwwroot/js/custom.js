$(document).ready(function () {
    checkSession();
    ShowEmployeedata();
});
function checkSession() {
    $.ajax({
        url: '/Ajax/Index',
        type: 'GET',
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',

        beforeSend: function () {
            console.log("Checking session...");
        },

        success: function (res) {
            if (res.status === "redirect") {
                console.log("Redirecting to login...");
                window.location.href = res.url;
                return;
            }
            if (res.status === "success") {
                console.log("You are logged in");
            }
        },

        error: function (xhr, status, error) {
            console.log("AJAX error: " + error);
        }
    });
}
function ShowEmployeedata() {
    debugger;
    $.ajax({
        url: '/Ajax/UserEmployees',
        type: 'GET',
        dataType: 'json',
        contentType: 'application/json; charset=utf-8;',
        success: function (result,statu,xhr) {
            var object = '';

            $.each(result, function (index, item) {
                object += '<tr>';
                object += '<td>' + item.id + '</td>';
                object += '<td>' + item.name + '</td>';
                object += '<td>' + item.email + '</td>';
                object += '<td>' + item.password + '</td>';
                object += '<td>' + item.salary + '</td>';
                object += '<td>' + item.role + '</td>';
                object += '<td><button class="btn btn-success" id="btnedit" onclick="Edit(' + item.id + ')">Edit</button>|| <a href="#" class="btn btn-danger"onclick="Delete(' + item.id + ')">Delete</a></td > ';
                object += '</tr>';
            });

            $('#table-data').html(object);
        },
        error: function () {
            alert("Data can't be retrieved");
        }
    });
}
    $('#btnAddEmployee').click(function () {
        $('#EmployeeModal').modal('show');
        ClearTextbox();
    $('#AddEmployee').css('display', 'block');
    //$('#EmployeeId').hide();
    $('#Edit').css('display', 'block');
    $('#EmployeeHeading').text('Add Employee');
    //$('#EmployeeHeading2').text('Update Employee');

})
function AddEmployee() {
    debugger
    var ObjData = {
        name: $('#Name').val(),
        email: $('#Email').val(),
        password: $('#Password').val(),
        salary: $('#Salary').val(),
        role: $('#Role').val()
    };
    $.ajax({
        url: '/Ajax/UserEmployees',
        type: 'Post',
        data: JSON.stringify(ObjData),
        contentType: 'application/json;Charset=utf-8;',
        dataType: 'json',
        success: function () {
            alert('Data saved');
            ClearTextbox();
            $('#AddEmployee').show();
            ShowEmployeedata();
            HideModelPopUp();
            $('#EmployeeModal').hide();

        },
        error: function () {
            alert('Data is not get saved');
        }
    })
}
function HideModelPopUp() {
    $('#EmployeeModal').modal('hide');
}
function ClearTextbox() {
    $('#Name').val('');
    $('#Email').val('');
    $('#Password').val('');
    $('#Salary').val('');
    $('#Role').val('');
    $('#EmployeeId').val('');
}
function Edit(id) {

    $.ajax({
        url: '/Ajax/Edit?id=' + id,
        type: 'GET',
        dataType: 'json',

        success: function (response) {

            $('#EmployeeModal2').modal('show');
            $('#EmployeeHeading2').text('Edit Employee');

            $('#EmployeeId2').val(response.id);
            $('#name').val(response.name);
            $('#email').val(response.email);
            $('#password').val(response.password);
            $('#salary').val(response.salary);
            $('#role').val(response.role);
            ShowEmployeedata();
            $('#btnupdate').show();
        },

        error: function () {
            alert('Error: Data not found');
        }
    });
}
//$('#btnedit').click(function () {
//    $('#EmployeeModal2').show();
//    ShowEmployeedata();


//})

//$('#btneditEmployee').click(function () {

//    $('#EmployeeModal').modal('show');

//    //ClearTextbox();

//    $('#EmployeeHeading').text('Edit Employee');
//    ShowEmployeedata();

//    $('#btnupdate').show();

//    $('#AddEmployee').hide();

//    $('#EmployeeId').prop('readonly', true);

//});


//function UpdateEmployee() {

//    var emp = {
//        Id: $('#EmployeeId').val(),
//        Name: $("#name").val(),
//        Email: $("#email").val(),
//        Password: $("#password").val(),
//        Salary: $("#salary").val(),
//        Role: $('#role').val(),
//    };

//    console.log("Sending to controller:", emp);

//    $.ajax({
//        url: '/Ajax/Update',
//        type: 'POST',
//        contentType: 'application/json; charset=utf-8',
//        data: JSON.stringify(emp),
//        success: function (response) {

//            alert(response);

//            ShowEmployeedata();
//            HideModelPopUp();
//        },
//        error: function (xhr) {
//            console.log(xhr);
//            alert("Error: " + xhr.status);
//        }
//    });
//};

$("#btnupdate").click(function () {

    var obj = {
        Id: $("#EmployeeId2").val(),
        Name: $("#name").val(),
        Email: $("#email").val(),
        Password: $("#password").val(),
        Salary: $("#salary").val(),
        Role: $("#role").val()
    };

    $.ajax({
        url: "/Ajax/Update",
        type: "POST",
        data: JSON.stringify(obj),
        contentType: "application/json;charset=utf-8;",
        dataType: "json",

        success: function (response) {
            alert("Updated!");
            $("#EmployeeModal2").modal("hide");
            ShowEmployeedata();
        },
        error: function (xhr) {
            console.log(xhr.responseText);
        }
    });

});


//$("#btnupdate").click(function () {

//    var obj = {
//        Id: $("#EmployeeId2").val(),
//        Name: $("#name").val(),
//        Email: $("#email").val(),
//        Password: $("#password").val(),
//        Salary: $("#salary").val()
//    };

//    $.ajax({
//        url: '/Ajax/Update',
//        type: 'POST',
//        data: JSON.stringify(obj),
//        contentType: 'application/json; charset=utf-8',
//        dataType: 'json',

//        success: function (response) {
//            if (response.status === "success") {
//                alert("Record Updated Successfully!");

//                $("#EmployeeModal2").modal('hide');
//                ShowEmployeedata();  // reload the table
//            }
//            else {
//                alert("Update failed!");
//            }
//        },
//        error: function () {
//            alert("Error during update!");
//        }
//    });
//});

    function Delete(id) {
        if (confirm('Are you sure, you want to delete this record?')) {
            $.ajax({
                url: '/Ajax/Delete?id=' + id,
                type: 'Get',
                success: function () {
                    alert('Record Deleted');
                    ShowEmployeedata();

                },
                error: function () {
                    alert("Data can't be deleted");
                }

            });
        }
    }
    function Login() {
        var data = {
            Email: $("#email").val(),
            Password: $("#password").val()
        };

        $.ajax({
            url: '/Ajax/Login',
            type: 'POST',
            data: JSON.stringify(data),
            contentType: 'application/json; charset=utf-8;',
            success: function (response) {
                if (response.success) {
                    alert("Login Success");
                    window.location.href = "/Ajax/Index";
                } else {
                    alert(response.message);
                }
            }
        });
    }
    function Logout() {
        $.ajax({
            url: '/Ajax/Logout',
            type: 'GET',
            success: function (response) {
                if (response.success) {
                    window.location.href = "/Ajax/Login";
                }
            }
        });

    }
