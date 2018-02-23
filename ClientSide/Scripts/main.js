(function () {
    angular.module('ScaleCrud', []);
})();
(function () {
    'use strict';

    angular.module('ScaleCrud')
        .controller('ScaleCrudController', ScaleCrudController);

    ScaleCrudController.$inject = ['$scope'];

    function ScaleCrudController($scope) {
        var vm = this;
        // place holder
        vm.btnWeight = _btnWeight;
        vm.btnSend = _btnSend;
        $scope.c.currentScale = "";

        function _btnWeight() {
            //Working
            console.log("doing something");
            var chat = $.connection.ConnectorHub;
            // Action to recieve messages
            chat.client.recieveMessage = function (message) {
                $('#incomingData').append($('<p />').text(message));
                $scope.c.currentScale = message;
                //$scope.c.currentScale = message;
            }
            // Init Connection
            $.connection.hub.start().done(function () {
                // On button click sends a message
                $('#btnSend').click(function () {
                    chat.server.sendMessage($('#message').val());
                })
            });
            $('#onlineOffline').append("Connected");
            $('#onlineOffline').css('color', 'green');

        }
        function _btnSend() {
            // Empty
        }
    }
})();