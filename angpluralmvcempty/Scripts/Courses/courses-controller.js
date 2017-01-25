//(function () {
//    'use strict';

//    angular
//        .module('app')
//        .controller('courses_controller', courses_controller);

//    courses_controller.$inject = ['$location']; 

//    function courses_controller($location) {
//        /* jshint validthis:true */
//        var vm = this;
//        vm.title = 'courses_controller';

//        activate();

//        function activate() { }
//    }
//})();
'use strict';

registrationModule.controller("CoursesController", function ($scope, courseRepository) {
    $scope.courses = courseRepository.get();
});