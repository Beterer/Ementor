(function () {
    var app = angular.module('app');

    var controllerId = 'eMentor.views.class.list';
    app.controller(controllerId, [
        '$scope', 'abp.services.app.class', '$uibModal',
        function ($scope, classService, $uibModal, moment) {
            var vm = this;
            vm.calendarView = 'month';
            vm.calendarDay = new Date();
            vm.events = [];

            vm.calendarTitle = "Test Title"

            vm.isCellOpen = true;

            function showModal(action, event) {
                $uibModal.open({
                    templateUrl: 'App\Main\views\class\modalTestTemplate.html',
                    controller: function () {
                        var vm = this;
                        vm.action = action;
                        vm.event = event;
                    },
                    controllerAs: 'vm'
                });
            }

            vm.eventClicked = function (event) {
                showModal('Clicked', event);
            };

            vm.eventEdited = function (event) {
                showModal('Edited', event);
            };

            vm.eventDeleted = function (event) {
                showModal('Deleted', event);
            };

            vm.eventTimesChanged = function (event) {
                showModal('Dropped or resized', event);
            };

            vm.toggle = function ($event, field, event) {
                $event.preventDefault();
                $event.stopPropagation();
                event[field] = !event[field];
            };


            //vm.localize = abp.localization.getSource('Ementor');

            //vm.classes = undefined;
            //vm.class = undefined;

            vm.setClasses = function () {
                classService.getClasses().success(function (data) {
                    for(var i = 0; i < data.length; i++)
                    {
                        data[i].startsAt = new Date(data[i].startsAt); 
                        data[i].endsAt = new Date(data[i].endsAt);
                    }
                    vm.events = data;
                })
            };

            //vm.setClass = function () {
            //    classService.getClass(1).success(function (data) {
            //        vm.class = data;
            //    })
            //};

            $scope.init = function () {
                vm.setClasses();
                //vm.setClass();
            }
        }
    ]);
})();