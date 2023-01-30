//document.getElementById('btnSend').addEventListener('click', function () {
//    alert(document.getElementById('atext').value);
//})

// Button to send perform calulations and send grade to output label on click
$("#btnSend").click(function () {

    // Declare Variables for Calculator
    var grade;
    var assignments = $('#atext').val();
    var gproject = $('#gtext').val();
    var quizzes = $('#qtext').val();
    var midterm = $('#mtext').val();
    var final = $('#ftext').val();
    var intex = $('#itext').val();
    var letter;

    // Calculate Weighted Grade
    grade = ((assignments * .5) + (gproject * .1) + (quizzes * .1) + (midterm * .1) + (final * .1) + (intex * .1))

    // If statements to decide which letter grade to add based on calculated grade value
    if (grade >= 94) {
        letter = "(A)";
    }
    else if (grade >= 90) {
        letter = "(A-)"
    }
    else if (grade >= 87) {
        letter = "(B+)"
    }
    else if (grade >= 84) {
        letter = "(B)"
    }
    else if (grade >= 80) {
        letter = "(B-)"
    }
    else if (grade >= 77) {
        letter = "(C+)"
    }
    else if (grade >= 74) {
        letter = "(C)"
    }
    else if (grade >= 70) {
        letter = "(C-)"
    }
    else if (grade >= 67) {
        letter = "(D+)"
    }
    else if (grade >= 64) {
        letter = "(D)"
    }
    else if (grade >= 60) {
        letter = "(D-)"
    }
    else {
        letter = "(E)"
    }

    // dynamically generate output with grade letter for label on webpage
    $('#output').html("Overall Grade: " + grade + "% " + letter);
})
