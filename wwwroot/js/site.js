
function GetAnswers() {
    $.ajax({
        type: "GET",
        url: "/HomeController/GetAnswers",
        contentType: "application/json",
        dataType: 'json',
        success: function (result) {
            CheckAnswers(result);
        },
        error: function (req, status, error) {
            alert("Error getting answers!");
        }
    });
}

function CheckAnswers(answers) {
    answers.forEach(ShowCorrectOrNot);
}

function ShowCorrectOrNot(solution) {
    var answer = $("#" + solution.id + " input[type='radio']:checked").val();

    if (answer != solution.correctAnswer) {
        $("#" + solution.id + " input[type='radio']:checked").closest('span').css("border", "2px solid red");
        $("[name=" + solution.id + "][value='" + solution.correctAnswer +"']").closest('span').css("border", "2px solid green")
    }

    else {
        $("#" + solution.id + " input[type='radio']:checked").closest('span').css("border", "2px solid green")
    }
}
