
var examSubmissionService = new ExamSubmissionService();

//$(window).load(function () {
//    examSubmissionService.GetQuestionsAlreadySavedData(CandidateQuestionData).then(function (response) {
//        sourceEditor.setValue(decode(data["source_code"]));
//        $selectLanguage.dropdown("set selected", data["language_id"]);
//        $compilerOptions.val(data["compiler_options"]);
//        $commandLineArguments.val(data["command_line_arguments"]);
//        stdinEditor.setValue(decode(data["stdin"]));
//        stdoutEditor.setValue(decode(data["stdout"]));
//        stderrEditor.setValue(decode(data["stderr"]));
//        compileOutputEditor.setValue(decode(data["compile_output"]));
//        sandboxMessageEditor.setValue(decode(data["message"]));
//        var time = (data.time === null ? "-" : data.time + "s");
//        var memory = (data.memory === null ? "-" : data.memory + "KB");
//        $statusLine.html(`${data.status.description}, ${time}, ${memory}`);
//        changeEditorLanguage();

//    });
//});


$(window).on('load', function () {
    //if ($('#SubmissionResult_ID').val() !== undefined && $('#SubmissionResult_ID').val() !== null) {
    //    var SubmissionData = $('#SubmissionResult_ID').val();
    //    var obj = JSON.parse(SubmissionData);
    //    sourceEditor.setValue(obj.sourceCode);
    //    //$(".view-lines").text(obj.sourceCode);
    //    //sourceEditor.val(obj.sourceCode);
    //    //        $selectLanguage.dropdown("set selected", data["language_id"]);
    //    //$compilerOptions.val(obj.compilerOptions);
    //    //$commandLineArguments.val(obj.commandLineArguments);
    //    //stdinEditor.val(obj.standardInput);
    //    //stdoutEditor.val(obj.standardOutput);
    //    //stderrEditor.val(obj.standardError);
    //    //compileOutputEditor.val(obj.compileTimeOutput);
    //    //sandboxMessageEditor.val(obj.sandboxMessage);
    //    //        var time = (data.time === null ? "-" : data.time + "s");
    //    //        var memory = (data.memory === null ? "-" : data.memory + "KB");
    //    //$statusLine.html(`${data.status.description}, ${time}, ${memory}`);
    //    //        changeEditorLanguage();

   // }

    setTimeout(callonload, 1000);

    //var name = '@Html.Raw(Model.SubmissonResult.SourceCode)';

});

function callonload() {
    if ($('#SubmissionResult_ID').val() !== undefined && $('#SubmissionResult_ID').val() !== null) {
        var SubmissionData = $('#SubmissionResult_ID').val();
        var obj = JSON.parse(SubmissionData);
        sourceEditor.setValue(obj.sourceCode);
    }
}

function SubmitAnswer(nextPageNumber, positionId, questionNumber, candidateId, requestFrom) {

    var CandidateQuestionData = new Object();
    CandidateQuestionData.CandidateId = candidateId;
    CandidateQuestionData.Id = questionNumber;
    CandidateQuestionData.PageNumber = nextPageNumber;
    CandidateQuestionData.QuestionNumber = questionNumber;
    CandidateQuestionData.PositionId = positionId;
    CandidateQuestionData.SourceCode = sourceEditor.getValue();
    CandidateQuestionData.LanguageId = $selectLanguage.val();
    CandidateQuestionData.CompilerOptions = $compilerOptions.val();
    CandidateQuestionData.CommandLineArguments = $commandLineArguments.val();
    CandidateQuestionData.StandardInput = stdinEditor.getValue();
    CandidateQuestionData.StandardOutput = stdoutEditor.getValue();
    CandidateQuestionData.StandardError = stderrEditor.getValue();
    CandidateQuestionData.CompileTimeOutput = compileOutputEditor.getValue();
    CandidateQuestionData.SandboxMessage = sandboxMessageEditor.getValue();
    CandidateQuestionData.StatusLine = $statusLine.html();


    examSubmissionService.SaveExamSubmissionOfCandidate(CandidateQuestionData).then(function (response) {
        console.log(response);
        if (requestFrom == "SubmitTest") {
            window.location.href = '/Exam/TestSubmit';
        }
        else if (requestFrom == "Save"){
            window.location.href = '/Exam/RenderQuestion?pageNumber=' + (response.pageNumber-1) + '&positionId=' + response.positionId + '&candidateId=' + response.candidateId;

        }
        else {
            window.location.href = '/Exam/RenderQuestion?pageNumber=' + response.pageNumber + '&positionId=' + response.positionId + '&candidateId=' + response.candidateId;
        }
    });

}
