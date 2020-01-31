"use strict";


$(document).ready(function () {
    $.get("Assign/CreateCoursePartial", function (data, status) {
        $("#coursePartial").html(data);
    });
});

//function CreatePartial() {
//    $.get("Assign/CreateCoursePartial", function (data, status) {
//        $("#coursePartial").html(data);
//    });
//}