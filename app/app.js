//module
(function() {
  'use strict';

  angular
    .module('toDoAppList', []);
})();

(function() {
    'use strict';
// Controller start
    angular
      .module('toDoAppList')
      .controller('ToDoController', ToDoController);

    ToDoController.$inject = ['toDoFactory'];

    function ToDoController(toDoFactory) {
      var vm = this;
      vm.toDoItem = "";
      vm.toDoList = [];
      vm.toDoObject = {};
      //add new list item to database
      vm.add = function(toDoObject) {
        toDoFactory
          .addTodos(toDoObject)
          .then(function(response) {
              console.log(response);
              addToDo(response.data);
          },
          function(error) {
            console.log(error);
          });
    };
    //add new ToDo to list customer can view
    function addToDo(todo) {
      vm.toDoList.push({
        todo: vm.toDoObject.ToDoItem,
        priority: vm.toDoObject.Priority
      });
    }


  }

})();
