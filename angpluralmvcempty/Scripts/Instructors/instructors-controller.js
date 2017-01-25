//(function () {
//    'use strict';

//    angular
//        .module('app')
//        .controller('instructors_controller', instructors_controller);

//    instructors_controller.$inject = ['$location']; 

//    function instructors_controller($location) {
//        /* jshint validthis:true */
//        var vm = this;
//        vm.title = 'instructors_controller';

//        activate();

//        function activate() { }
//    }
//})();
'use strict';

registrationModule.controller("InstructorsController", function ($scope, instructorRepository) {
    $scope.instructors = instructorRepository.get();
});