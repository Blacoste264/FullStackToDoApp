(function() {
  'use strict';

  angular
    .module('toDoAppList')
    .factory('toDoFactory', toDoFactory);

  toDoFactory.$inject = ['$http'];

  // Factory start

  function toDoFactory($http) {
    var service = {
      addTodos: addTodos,
    };
    return service;

    ////////// Post new ToDo

    function addTodos(object) {
      return $http({
          method: 'POST',
          url: 'http://localhost:52149/api/ToDoes',
          data: object,
          headers: {
            'Content.Type': 'application/json; charset=utf-8'
          }
        })
        .then(function successCallback(response) {
            return response;
          },
          function errorCallback(error) {
            return error;
          });
      }
    }
})();
