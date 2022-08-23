var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/products", {
        templateUrl : "views/pages/products.html",
        controller: 'products'
    })
    .when("/products/create", {
        templateUrl : "views/pages/create.html",
        controller: 'create'
    })
    .when("/home", {
        templateUrl : "views/pages/home.html",
        controller: 'create'
    })
    .when("/delete/:id", {
        templateUrl : "views/pages/home.html",
        controller: 'delete'
    })
    .when("/update/:id", {
        templateUrl : "views/pages/update.html",
        controller: 'update'
    })
    .otherwise({
        redirectTo:"/products"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);
