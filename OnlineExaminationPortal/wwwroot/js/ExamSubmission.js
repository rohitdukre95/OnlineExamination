
var examSubmissionService = new ExamSubmissionService();

$(window).load(function () {
    //examSubmissionService.GetQuestionsAlreadySavedData(CandidateQuestionData).then(function (response) {
    //    sourceEditor.setValue(decode(data["source_code"]));
    //    $selectLanguage.dropdown("set selected", data["language_id"]);
    //    $compilerOptions.val(data["compiler_options"]);
    //    $commandLineArguments.val(data["command_line_arguments"]);
    //    stdinEditor.setValue(decode(data["stdin"]));
    //    stdoutEditor.setValue(decode(data["stdout"]));
    //    stderrEditor.setValue(decode(data["stderr"]));
    //    compileOutputEditor.setValue(decode(data["compile_output"]));
    //    sandboxMessageEditor.setValue(decode(data["message"]));
    //    var time = (data.time === null ? "-" : data.time + "s");
    //    var memory = (data.memory === null ? "-" : data.memory + "KB");
    //    $statusLine.html(`${data.status.description}, ${time}, ${memory}`);
    //    changeEditorLanguage();

//});
});

function SubmitAnswer(nextPageNumber, positionId, questionNumber, candidateId) {

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
        window.location.href = '/Exam/RenderQuestion?pageNumber=' + response.pageNumber + '&positionId=' + response.positionId + '&candidateId=' + response.candidateId;
    });

}
