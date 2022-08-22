app.controller("create",function($scope,ajax){
    ajax.get("https://localhost:44388/api/warehouses",success,error);
    function success(response){
        $scope.warehouses=response.data;
    }
    function error(error){

    }
    $scope.submit=function(){
        ajax.post("https://localhost:44388/api/product/create",$scope.post,success,error);
        function success(response){
            alert("Product Successfully Created.");
        }
        function error(error){
            alert("There was an error.");
        }
    };

});
