// wwwroot/js/appointment-script.js

$(document).ready(function () {
    $("#PoliclinicID").change(function () {
        var policlinicId = $(this).val();
        if (policlinicId) {
            $.ajax({
                type: "GET",
                url: "/Appointment/GetDoctorsForPoliclinic",
                data: { policlinicId: policlinicId },
                success: function (data) {
                    $("#DoctorID").empty();
                    $.each(data, function (index, doctor) {
                        $("#DoctorID").append($('<option>', {
                            value: doctor.doctorID,
                            text: doctor.doctorName
                        }));
                    });
                },
                error: function (error) {
                    console.error("GetDoctorsForPoliclinic Error:", error);
                }
            });
        } else {
            $("#DoctorID").empty();
        }
    });
});
