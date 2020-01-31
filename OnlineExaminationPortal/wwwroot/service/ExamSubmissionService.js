var ExamSubmissionService = function () {
    var commonModel = new CommonModel();
    //var appConfig = window.config;
    //return appConfig.ActionUrl + path;
    return {
        GetExamSubmissionOfCandidate: function (Association) {
            var deferred = new jQuery.Deferred();
            $.ajax({
                url: commonModel.getUrlPath('RegLibAssociation/GetAssociation'),
                type: 'POST',
                data: JSON.stringify(Association),
                dataType: 'json',
                contentType: 'application/json; charset=utf-8',
                async: false,
                error: function (xhr) {
                    return deferred.reject(xhr.responseText);
                },
                success: function (response) {
                    return deferred.resolve(response);
                }
            });
            return deferred.promise();
        },

        SaveExamSubmissionOfCandidate: function (QuestionSubmission) {
            var deferred = new jQuery.Deferred();
            $.ajax({
                url: commonModel.getUrlPath('/Exam/SaveDataOnNextAndBack'),              
                data: JSON.stringify(QuestionSubmission),
                type: 'POST',
                contentType: 'application/json; charset=utf-8',
                dataType: "json",
                error: function (xhr) {
                    return deferred.reject(xhr.responseText);
                },
                success: function (response) {
                    return deferred.resolve(response);
                }
            });
            return deferred.promise();
        }
    }
}