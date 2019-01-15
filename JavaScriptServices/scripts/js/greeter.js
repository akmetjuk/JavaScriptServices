// greeter.js
module.exports = function (callback, firstName, surname) {

    var greet = function (firstName, surname) {
        return "Hello " + firstName + " " + surname;
    }

    callback(null, greet(firstName, surname));
}