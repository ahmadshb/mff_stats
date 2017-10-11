(function () {

    angular.module('mainApp').config(function ($stateProvider, $urlRouterProvider) {

        //$urlRouterProvider.otherwise("/viewAll");

        var listCharacter = {
            name: 'list',
            url: '/list',
            templateUrl: 'ManageList.html'
        }

        var addCharacter = {
            name: 'add',
            url: '/add',
            templateUrl: 'ManageAdd.html'

        }

        var viewCharacter = {
            name: 'view',
            url: '/view',
            templateUrl: 'ManageView.html'

        }

        //var vipFaqState = {
        //    name: 'vip',
        //    url: '/vip',
        //    templateUrl: 'Myfaqs-vip.html'
        //}

        //var guardFaqState = {
        //    name: 'guard',
        //    url: '/guard',
        //    templateUrl: 'Myfaqs-guard.html'
        //}

        //var editFaqState = {
        //    name: 'edit',
        //    url: '/edit',
        //    templateUrl: 'Myfaqs-new.html'
        //}

        $stateProvider.state(listCharacter);
        $stateProvider.state(addCharacter);
        $stateProvider.state(viewCharacter);

        //$stateProvider.state(vipFaqState);
        //$stateProvider.state(guardFaqState);
        //$stateProvider.state(editFaqState);

    });

})();

