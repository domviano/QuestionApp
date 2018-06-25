app.controller('QuestionController', ['$scope', 'QuestionService', function ($scope, QuestionService) {

    QuestionService.getQuestions().success(function (questions) {
        $scope.questions = questions;
    });

    $scope.saveSubmission = function (questions) {
        if (!$scope.fullName) {
            alert('Please provide your name and email address!');
            return;
        }
        
        var request = {
            reviewer: {
                fullName: $scope.fullName,
                email: $scope.Email
            },
            questions: questions
        };

        QuestionService.submission(request).success(function (data) {
            if (data != 'EASTER-EGG-COMMENCE')
                alert("Thank you!");
            else {
                alert("Biz Library Rocks!");
                window.location.href = "https://www.bizlibrary.com/";
            }
          
        });
    };
}]);