var CommonModel = function () {
    return {
        getUrlPath: function (path) {
            var appConfig = window.origin;
            return appConfig + path;
        }
    }
}