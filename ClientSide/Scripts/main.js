(function () {
    angular.module('ScaleCrud', ['ngTable']);
})();
(function () {
    'use strict';

    angular.module('ScaleCrud')
        .controller('ScaleCrudController', ScaleCrudController);

    ScaleCrudController.$inject = ['$scope', 'NgTableParams'];

    function ScaleCrudController($scope, NgTableParams) {
        var vm = this;
        // JSON Data for the table *Static*
        var data = [
            {
                "Status": "none",
                "Base": "352-91",
                "Description": "Testing",
                "Amount": 16.13,
                "CumAmt": 16.13,
                "PouredAmt": 0
            },
            {
                "Status": "none",
                "Base": "A929",
                "Description": "Testing",
                "Amount": 8.27,
                "CumAmt": 24.4,
                "BaseRGB": "#3A352F",
                "PouredAmt": 0
            },
            {
                "Status": "none",
                "Base": "M25",
                "Description": "Testing",
                "Amount": 75.61,
                "CumAmt": 100,
                "BaseRGB": "#C8CFD2",
                "PouredAmt": 0
            }
        ];
        // [Buttons]
        vm.btnWeight = _btnWeight;
        vm.btnSend = _btnSend;
        vm.btnConnect = _btnConnect;
        // Global Var's
        $scope.c.currentScale = "";
        $scope.c.tableParams = new NgTableParams({}, { dataset: data });
        console.log(data);

        // [Btn] Connect
        function _btnConnect() {
            //Working
            var chat = $.connection.ConnectorHub;
            // Action to receive messages
            chat.client.recieveMessage = function (message) {
                $('#incomingData').append($('<p />').text(message));
                $scope.c.currentScale = message;
                //$scope.c.currentScale = message;
            }
            // Init Connection
            $.connection.hub.start().done(function () {
                $scope.c.isConnected = "Connected"
                // On button click sends a message
                $('#btnSend').click(function () {
                    chat.server.sendMessage($('#message').val());
                })
            });
            $('#isConnected').css('color', 'green');
        }
        // [Btn] Weight
        function _btnWeight() {
            // Not used
        }

        // [Btn] Send
        function _btnSend() {
            // Empty
        }
    }
})();