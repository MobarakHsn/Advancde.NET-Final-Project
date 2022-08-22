app.controller("products",function($scope,$http,ajax){
    ajax.get("https://localhost:44388/api/products",success,error);
    function success(response){
      $scope.products=response.data;
    }
    function error(error){

    }

});
