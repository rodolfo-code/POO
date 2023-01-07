var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Vehicle = /** @class */ (function () {
    function Vehicle(brand, automaker) {
        this.brand = brand;
        this.automaker = automaker;
    }
    Vehicle.prototype.speed = function () {
        console.log("O ".concat(this.brand, " acelera pra caramba!"));
        return "O  ".concat(this.brand, " acelera muito!");
    };
    return Vehicle;
}());
var Car = /** @class */ (function (_super) {
    __extends(Car, _super);
    function Car(brand, automaker) {
        return _super.call(this, brand, automaker) || this;
    }
    return Car;
}(Vehicle));
var carro = new Car("Corsa", "GM");
var ac = carro.speed();
console.log(ac);
// carro.speed();
