app.controller("delete",function(ajax,$routeParams){
    ajax.get("https://localhost:44388/api/product/delete/"+$routeParams.id,success,error);
    function success(response){
        alert("Product successfully deleted.");
    }
    function error(error){
        alert("There was an error!");
    }
});
