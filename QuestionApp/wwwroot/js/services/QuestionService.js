app.factory('QuestionService', ['$http', function ($http, $cookieStore) {

    var baseApiUrl = '/api/';

    var config = { cache: false }

    var getQuestions = function () {
        var url = baseApiUrl + 'questions';
        return $http.get(url, config);
    };

    var submission = function (request) {
        var url = baseApiUrl + 'submission';
        return $http.post(url, request, config);
    };

    return {
        getQuestions: getQuestions, 
        submission: submission
    }

}]);