(function () {
    var app = angular.module('app');

    var controllerId = 'eMentor.views.class.list';
    app.controller(controllerId, [
        '$scope', 'abp.services.app.class',
        function ($scope, classService) {
            var vm = this;

            vm.localize = abp.localization.getSource('Ementor');

            vm.classes = [];

            vm.setClasses = function () {
                classService.getClasses().success(function (data) {
                    vm.classes = data.classes;
                })
            };

            $scope.init = function () {
                vm.setClasses();
            }
        }
    ]);
})();