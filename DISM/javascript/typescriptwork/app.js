// let abb = "Hello world";
// console.log(abb);
var user = /** @class */ (function () {
    function user() {
    }
    user.prototype.test = function () {
        console.log("testing");
    };
    return user;
}());
var objuser = new user();
objuser.test();
// function sum(num1 :number ,num2 : number){
//     console.log(num1 + num2);
// }
// sum(1,2);
