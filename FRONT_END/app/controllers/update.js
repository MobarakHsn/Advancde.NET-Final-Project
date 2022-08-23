app.controller("update",function($scope,ajax,$routeParams){

    $scope.submit=function(){
        var data={
            id:$routeParams.id,
            product_name:$scope.product_name,
            weight_unit:$scope.weight_unit,
            dimention:$scope.dimention,
            selling_price:$scope.selling_price,
            status_sale:$scope.status_sale,
            stock:$scope.stock,
            status_purchase:$scope.status_purchase,
            dimention_unit:$scope.dimention_unit,
            product_description:$scope.product_description,
            product_condition:$scope.product_condition,
            tax:$scope.tax,
            warehouse_name:$scope.warehouse_name,
            weight:$scope.weight,
            nature:$scope.nature,
        };
        ajax.post("https://localhost:44388/api/product/update",data,success,error);
        function success(response){
            if(response.data==true)
                alert("Product Successfully Updated.");
            else
                alert("Product not found!.");
        }
        function error(error){
            alert("There was an error.");
        }
    };
    
    ajax.get("https://localhost:44388/api/product/"+$routeParams.id,success,error);
    function success(response){
        if(response.data!=null)
        {
            ajax.get("https://localhost:44388/api/warehouses",success,error);
            function success(response){
                $scope.warehouses=response.data;
            }
            function error(error){
            }
            var x=response.data;
            $scope.product_name=x.product_name;
            $scope.weight_unit=x.weight_unit;
            $scope.dimention=x.dimention;
            $scope.selling_price=x.selling_price;
            $scope.status_sale=x.status_sale;
            $scope.stock=x.stock;
            $scope.status_purchase=x.status_purchase;
            $scope.dimention_unit=x.dimention_unit;
            $scope.product_description=x.product_description;
            $scope.product_condition=x.product_condition;
            $scope.tax=x.tax;
            $scope.warehouse_name=x.warehouse_name;
            $scope.weight=x.weight;
            $scope.nature=x.nature;
            //alert($scope.post.product_name);
        }
    }
    function error(error){
        alert("There was an error!");
    }
    
});
