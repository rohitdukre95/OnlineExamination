
var examSubmissionService = new ExamSubmissionService();

function SubmitAnswer(nextPageNumber,experienceId,questionNumber,candidateId) {

    var CandidateQuestionData = new Object();
    CandidateQuestionData.CandidateId = candidateId;
    CandidateQuestionData.Id = questionNumber;
    CandidateQuestionData.PageNumber = nextPageNumber;
    CandidateQuestionData.QuestionNumber = questionNumber;
    CandidateQuestionData.ExperienceId = experienceId;
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
    });

}