FoodyApp.config(['$routeProvider', '$locationProvider',
    function ($routeProvider, $locationProvider) {
        $routeProvider
        .when('/places', {
            templateUrl: '/__get/ViewTemplate/HomePlace',
            controller: 'PlaceCtrl',
            resolve: {
                para: function ($route) {
                    $route.current.params.MenuId = 1;
                },
                //data: PlaceCtrl.InitData
            }
        })
        .when('/delivery', {
            templateUrl: '/__get/ViewTemplate/HomePlace',
            controller: 'PlaceCtrl',
            resolve: {
                para: function ($route) {
                    $route.current.params.IsDelivery = true;
                    $route.current.params.MenuId = 2;
                },
                //data: PlaceCtrl.InitData
            }
        })
        .when('/booking', {
            templateUrl: '/__get/ViewTemplate/HomePlace',
            controller: 'PlaceCtrl',
            resolve: {
                para: function ($route) {
                    $route.current.params.IsBooking = true;
                    $route.current.params.MenuId = 3;
                },
                //data: PlaceCtrl.InitData
            }
        })
        .when('/collections', {
            templateUrl: '/__get/ViewTemplate/HomeWishList',
            controller: 'WishListCtrl',
            resolve: {
                para: function ($route) {
                    $route.current.params.MenuId = 4;
                }
            }
        })
        .when('/foods', {
            templateUrl: '/__get/ViewTemplate/HomePhoto',
            controller: 'PhotoCtrl',
            resolve: {
                para: function ($route) {
                    $route.current.params.MenuId = 5;
                }
            }
        })
        .when('/video', {
            templateUrl: '/__get/ViewTemplate/HomeVideo',
            controller: 'VideoCtrl',
            resolve: {
                para: function ($route) {
                    $route.current.params.MenuId = 6;
                }
            }
        })
        .when('/reviews', {
            templateUrl: '/__get/ViewTemplate/HomeReview',
            controller: 'HomeReviewCtrl',
            resolve: {
                para: function ($route) {
                    $route.current.params.MenuId = 7;
                }
            }
        })
        .when('/:cate/articles', {
            templateUrl: '/__get/ViewTemplate/HomeArticle',
            controller: 'HomeArticleCtrl',
            resolve: {
                para: function ($route) {
                    $route.current.params.MenuId = 8;
                }
            }
        })
        .when('/e-card', {
            templateUrl: '/__get/ViewTemplate/HomeECard',
            controller: 'HomeECardCtrl',
            resolve: {
                para: function ($route) {
                    $route.current.params.MenuId = 9;
                }
            }
        })
        .when('/bank-card', {
            templateUrl: '/__get/ViewTemplate/HomeBankCard',
            controller: 'HomeBankCardCtrl',
            resolve: {
                para: function ($route) {
                    $route.current.params.MenuId = 10;
                }
            }
        })
        .when('/promotion', {
            templateUrl: '/__get/ViewTemplate/HomePromotion',
            controller: 'HomePromotionCtrl',
            resolve: {
                para: function ($route) {
                    $route.current.params.MenuId = 11;
                }
            }
        })
        .when('/newsfeed', {
            templateUrl: '/__get/ViewTemplate/HomeNewsFeed',
            controller: 'HomeNewsFeedCtrl',
            resolve: {
                para: function ($route) {
                    $route.current.params.MenuId = 12;
                }
            }
        })
        .otherwise({ redirectTo: '/places' });
        //.otherwise({ redirectTo: '/newsfeed' });
        //$locationProvider.html5Mode({
        //    enabled: true,
        //    requireBase: false
        //});
    }]);

//HomeApp.run(function ($rootScope) {
//    $rootScope.$on("$locationChangeStart", function (event, next, current) {
//    });
//});

//HomeApp.run(function ($rootScope, $location) {
//    $rootScope.$watch(function () {
//        //console.log($location);
//        return $location.path();
//        //return $location.url(); 
//    },
//     function (a) {
//         console.log('url has changed: ' + a);
//         // show loading div, etc...


//     });
//});
