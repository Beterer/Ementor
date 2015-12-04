﻿(function () {
    var app = angular.module('app');

    var controllerId = 'eMentor.views.class.list';
    app.controller(controllerId, [
        '$scope', 'abp.services.app.class',
        function ($scope, classService, $uibModal, $moment) {
            var vm = this;
            vm.calendarView = 'month';
            vm.calendarDay = new Date();
            vm.events = [
              {
                  title: 'An event',
                  type: 'warning',
                  startsAt: moment().startOf('week').subtract(2, 'days').add(8, 'hours').toDate(),
                  endsAt: moment().startOf('week').add(1, 'week').add(9, 'hours').toDate(),
                  draggable: true,
                  resizable: true
              }, {
                  title: '<i class="glyphicon glyphicon-asterisk"></i> <span class="text-primary">Another event</span>, with a <i>html</i> title',
                  type: 'info',
                  startsAt: moment().subtract(1, 'day').toDate(),
                  endsAt: moment().add(5, 'days').toDate(),
                  draggable: true,
                  resizable: true
              }, {
                  title: 'This is a really long event title that occurs on every year',
                  type: 'important',
                  startsAt: moment().startOf('day').add(7, 'hours').toDate(),
                  endsAt: moment().startOf('day').add(19, 'hours').toDate(),
                  recursOn: 'year',
                  draggable: true,
                  resizable: true
              }
            ];

            vm.calendarTitle = "Test Title"

            vm.isCellOpen = true;

            function showModal(action, event) {
                $uibModal.open({
                    templateUrl: 'modalContent.html',
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

            //vm.setClasses = function () {
            //    classService.getClasses().success(function (data) {
            //        vm.classes = data;
            //    })
            //};

            //vm.setClass = function () {
            //    classService.getClass(1).success(function (data) {
            //        vm.class = data;
            //    })
            //};

            //$scope.init = function () {
            //    vm.setClasses();
            //    vm.setClass();
            //}
        }
    ]);
})();